#region

using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using PokemonGoBot.Logging;
using PokemonGoBot.Tasks;
using PokemonGoBot.Utils;
using POGOProtos.Networking.Responses;
using RocketAPI;
using RocketAPI.Enums;
using RocketAPI.Exceptions;

#endregion


namespace PokemonGoBot
{
    internal class Logic
    {
        public static Client _client;
        public static ISettings _clientSettings;
        public static Inventory _inventory;
        public static BotStats _stats;
        public static Navigation _navigation;
        private GetPlayerResponse _playerProfile;

        private bool _isInitialized = false;

        public Logic(ISettings clientSettings)
        {
            _clientSettings = clientSettings;
            PositionCheckState.Execute();
            _client = new Client(_clientSettings);
            _inventory = new Inventory();
            _stats = new BotStats();
            _navigation = new Navigation();
        }  

        public async Task Execute(CancellationToken cancellationToken)
        {
            if (!_isInitialized) await LocationCheckOnStartUp(cancellationToken);

            while (true)
            {
                await Login(cancellationToken);

                await PostLoginExecute();

                await Task.Delay(10000, cancellationToken);
                Logger.Write("Debug Info: Execute canceld?");
            }
        }

        public async Task RefreshTokens()
        {
            switch (_clientSettings.AuthType)
            {
                case AuthType.Ptc:
                    await _client.Login.DoLogin();
                    break;
                case AuthType.Google:
                    await _client.Login.DoLogin();
                    break;
            }
        }

        public async Task LocationCheckOnStartUp(CancellationToken cancellationToken)
        {
            var latLngFromFile = PositionCheckState.LoadPositionFromDisk();
            if (latLngFromFile != null && Math.Abs(latLngFromFile.Item1) > 0 && Math.Abs(latLngFromFile.Item2) > 0)
                _client.Player.SetCoordinates(latLngFromFile.Item1, latLngFromFile.Item2,
                    _client.Settings.DefaultAltitude);
            else
                _client.Player.SetCoordinates(_client.Settings.DefaultLatitude, _client.Settings.DefaultLongitude,
                    _client.Settings.DefaultAltitude);

            if (Math.Abs(_clientSettings.DefaultLatitude) <= 0 || Math.Abs(_clientSettings.DefaultLongitude) <= 0)
            {
                Logger.Write($"Please change first Latitude and/or Longitude because currently your using default values!", LogLevel.Error);
                for (int i = 3; i > 0; i--)
                {
                    Logger.Write($"Bot will close in {i * 5} seconds!", LogLevel.Warning);
                    await Task.Delay(5000, cancellationToken);
                    cancellationToken.ThrowIfCancellationRequested();
                }
            }
            else
            {
                Logger.Write($"Make sure Lat & Lng is right. Exit Program if not! Lat: {_client.CurrentLatitude} Lng: {_client.CurrentLongitude}", LogLevel.Warning);
                for (int i = 3; i > 0; i--)
                {
                    Logger.Write($"Bot will continue in {i * 5} seconds!", LogLevel.Warning);
                    await Task.Delay(5000, cancellationToken);
                    cancellationToken.ThrowIfCancellationRequested();
                }
            }
        }

        public async Task Login(CancellationToken cancellationToken)
        {
            Logger.Write($"Logging in via: {_clientSettings.AuthType}", LogLevel.Info);

            try
            {
                if (_clientSettings.AuthType == AuthType.Ptc || _clientSettings.AuthType == AuthType.Google)
                    await _client.Login.DoLogin();
                else
                {
                    Logger.Write("Wrong AuthType");
                    Settings.Settings.cancellationTokenSource.Cancel();
                    cancellationToken.ThrowIfCancellationRequested();
                }
            }
            catch (Exception ex) when (ex is PtcOfflineException || ex is AccessTokenExpiredException)
            {
                Logger.Write("PTC Servers are probably down OR your credentials are wrong. Try google",
                    LogLevel.Error);
                Logger.Write("Trying again in 60 seconds...");
                Thread.Sleep(60000);
                await Execute(cancellationToken);
            }
            catch (LoginFailedException)
            {
                Logger.Write("Bad credentials!", LogLevel.Error);
                Settings.Settings.cancellationTokenSource.Cancel();
                cancellationToken.ThrowIfCancellationRequested();
            }
            catch (AccountNotVerifiedException)
            {
                Logger.Write("Account not verified!", LogLevel.Error);
                Settings.Settings.cancellationTokenSource.Cancel();
                cancellationToken.ThrowIfCancellationRequested();
            }
            catch (GoogleException e)
            {
                if (e.Message.Contains("NeedsBrowser"))
                {
                    Logger.Write(
                        "As you have Google Two Factor Auth enabled, you will need to insert an App Specific Password into the UserSettings.",
                        LogLevel.Error);
                    Logger.Write("Opening Google App-Passwords. Please make a new App Password (use Other as Device)",
                        LogLevel.Error);
                    await Task.Delay(7000);
                    try
                    {
                        Process.Start("https://security.google.com/settings/security/apppasswords");
                    }
                    catch (Exception)
                    {
                        Logger.Write("https://security.google.com/settings/security/apppasswords");
                        throw;
                    }
                }
                Logger.Write("Make sure you have entered the right Email & Password.", LogLevel.Error);
                Settings.Settings.cancellationTokenSource.Cancel();
                cancellationToken.ThrowIfCancellationRequested();
            }
            catch (InvalidProtocolBufferException ex) when (ex.Message.Contains("SkipLastField"))
            {
                Logger.Write("Connection refused. Your IP might have been Blacklisted by Niantic...",
                    LogLevel.Error);
                Settings.Settings.cancellationTokenSource.Cancel();
                cancellationToken.ThrowIfCancellationRequested();
            }
            catch (Exception e)
            {
                Logger.Write(e.Message + " from " + e.Source);
                Logger.Write("Error, trying automatic restart..", LogLevel.Error);
                await Execute(cancellationToken);
            }

            try
            {
                var playerStats = (await Inventory.GetPlayerStats()).FirstOrDefault();
                if (playerStats != null)
                {
                    Logger.Write(
                        "Player profile successfully received ;-)",
                        LogLevel.Warning);
                }
            }
            catch (Exception)
            {
                Logger.Write("Due to login failure your player profile could not be retrieved. - unconfirmed permban",
                    LogLevel.Error);
                Settings.Settings.cancellationTokenSource.Cancel();
                cancellationToken.ThrowIfCancellationRequested();
            }

            Logger.Write("Client logged in", LogLevel.Info);
        }

        public async Task PrintPlayerInfos()
        {
            await Inventory.GetCachedInventory();
            _playerProfile = await _client.Player.GetPlayer();
            BotStats.UpdateConsoleTitle();

            var playerStats = (await Inventory.GetPlayerStats()).FirstOrDefault();
            if (playerStats != null) BotStats.KmWalkedOnStart = playerStats.KmWalked;

            Logger.Write("----------------------------", LogLevel.None, ConsoleColor.Yellow);
            if (_clientSettings.AuthType == AuthType.Ptc)
                Logger.Write($"PTC Account: {BotStats.GetUsername(_playerProfile)}\n", LogLevel.None,
                    ConsoleColor.Cyan);
            Logger.Write($"Latitude: {_clientSettings.DefaultLatitude}", LogLevel.None,
                ConsoleColor.DarkGray);
            Logger.Write($"Longitude: {_clientSettings.DefaultLongitude}", LogLevel.None,
                ConsoleColor.DarkGray);
            Logger.Write("----------------------------", LogLevel.None, ConsoleColor.Yellow);
            Logger.Write("Your Account:\n");
            Logger.Write($"Name: {BotStats.GetUsername(_playerProfile)}", LogLevel.None,
                ConsoleColor.DarkGray);
            Logger.Write($"Team: {_playerProfile.PlayerData.Team}", LogLevel.None, ConsoleColor.DarkGray);
            Logger.Write($"Level: {BotStats.GetCurrentInfo()}", LogLevel.None, ConsoleColor.DarkGray);
            Logger.Write($"Stardust: {_playerProfile.PlayerData.Currencies.ToArray()[1].Amount}",
                LogLevel.None, ConsoleColor.DarkGray);
            Logger.Write("----------------------------", LogLevel.None, ConsoleColor.Yellow);
            await DisplayHighests();
            Logger.Write("----------------------------", LogLevel.None, ConsoleColor.Yellow);

            var pokemonsToNotTransfer = _clientSettings.PokemonToNotTransfer;
            var pokemonsToNotCatch = _clientSettings.PokemonToNotCatch;
            var pokemonsToEvolve = _clientSettings.PokemonToEvolve;

            await RecycleItemsTask.Execute();
            if (_client.Settings.UseLuckyEggs) await UseLuckyEggTask.Execute();
            if (_client.Settings.EvolvePokemon || _client.Settings.EvolveOnlyPokemonAboveIV)
                await EvolvePokemonTask.Execute();
            if (_client.Settings.TransferPokemon) await TransferPokemonTask.Execute();
            if (_client.Settings.UseCSVExport) await ExportPokemonToCsv.Execute(_playerProfile.PlayerData);
            if (_clientSettings.HatchEggs) await HatchEggsTask.Execute();
        }

        public async Task PostLoginExecute()
        {
            if (!_isInitialized) await PrintPlayerInfos();
            _isInitialized = true;

            while (true)
            {
                if (_clientSettings.MovementBy == "UseGPXPathing")
                    await FarmPokestopsGPXTask.Execute();
                else
                    await FarmPokestopsTask.Execute();

                await RefreshTokens();

                await Task.Delay(10000);
                Logger.Write("Debug Info: PostLoginExecute canceld?");
            }
        }

        private async Task DisplayHighests()
        {
            Logger.Write("====== DisplayHighestsCP ======", LogLevel.Info, ConsoleColor.Yellow);
            var highestsPokemonCp = await Inventory.GetHighestsCp(15);
            string space = " ";
            foreach (var pokemon in highestsPokemonCp)
            {
                if (PokemonInfo.CalculatePokemonPerfection(pokemon) > 100)
                    space = "\t";

                Logger.Write(
                    $"# CP {pokemon.Cp.ToString().PadLeft(4, ' ')}/{PokemonInfo.CalculateMaxCp(pokemon).ToString().PadLeft(4, ' ')} | ({PokemonInfo.CalculatePokemonPerfection(pokemon).ToString("0.00")}% perfect){space}| Lvl {PokemonInfo.GetLevel(pokemon).ToString("00")}\t NAME: '{pokemon.PokemonId}'",
                    LogLevel.Info, ConsoleColor.Yellow);
            }

            Logger.Write("====== DisplayHighestsPerfect ======", LogLevel.Info, ConsoleColor.Yellow);
            var highestsPokemonPerfect = await Inventory.GetHighestsIv(15);
            foreach (var pokemon in highestsPokemonPerfect)
            {
                if (PokemonInfo.CalculatePokemonPerfection(pokemon) > 100)
                    space = "\t";

                Logger.Write(
                    $"# CP {pokemon.Cp.ToString().PadLeft(4, ' ')}/{PokemonInfo.CalculateMaxCp(pokemon).ToString().PadLeft(4, ' ')} | ({PokemonInfo.CalculatePokemonPerfection(pokemon).ToString("0.00")}% perfect){space}| Lvl {PokemonInfo.GetLevel(pokemon).ToString("00")}\t NAME: '{pokemon.PokemonId}'",
                    LogLevel.Info, ConsoleColor.Yellow);
            }
        }
    }
}
 