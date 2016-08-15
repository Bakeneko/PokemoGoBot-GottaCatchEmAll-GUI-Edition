using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGoBot.GUI.Settings
{
    internal class BasicSettings
    {
        public static readonly Dictionary<string, string> SettingsKeys = new Dictionary<string, string>();

        public static void CheckAndUpdateFile()
        {
            SettingsKeys.Add("AuthType", "Ptc");
            SettingsKeys.Add("UserNameOrEmail", "");
            SettingsKeys.Add("UserPassword", "");
            SettingsKeys.Add("DefaultLatitude", "0");
            SettingsKeys.Add("DefaultLongitude", "0");
            SettingsKeys.Add("DefaultAltitude", "10");

            SettingsKeys.Add("MovementBy", "Default");
            SettingsKeys.Add("WalkingSpeedInKilometerPerHour", "15");
            SettingsKeys.Add("MaxTravelDistanceInMeters", "1000");

            SettingsKeys.Add("GPXFile", "");
            SettingsKeys.Add("GPXIgnorePokestops", "false");

            SettingsKeys.Add("UseProxy", "false");
            SettingsKeys.Add("ProxyHost", "0.0.0.0");
            SettingsKeys.Add("ProxyPort", "0001");
            SettingsKeys.Add("ProxyUsername", "");
            SettingsKeys.Add("ProxyPassword", "");

            SettingsKeys.Add("UsePokemonToNotCatchList", "true");
            SettingsKeys.Add("UsePokemonToNotTransferList", "true");
            SettingsKeys.Add("UsePokemonToEvolveList", "true");

            SettingsKeys.Add("CatchPokemon", "true");
            SettingsKeys.Add("CatchIncensePokemon", "false");
            SettingsKeys.Add("CatchLuredPokemon", "false");

            SettingsKeys.Add("EvolvePokemon", "true");
            SettingsKeys.Add("EvolveOnlyPokemonAboveIV", "false");
            SettingsKeys.Add("EvolveOnlyPokemonAboveIVValue", "95");
            SettingsKeys.Add("EvolveKeepCandiesValue", "200");

            SettingsKeys.Add("TransferPokemon", "true");
            SettingsKeys.Add("NotTransferPokemonsThatCanEvolve", "false");
            SettingsKeys.Add("UseTransferPokemonKeepAllAboveCP", "true");
            SettingsKeys.Add("TransferPokemonKeepAllAboveCPValue", "2000");
            SettingsKeys.Add("UseTransferPokemonKeepAllAboveIV", "true");
            SettingsKeys.Add("TransferPokemonKeepAllAboveIVValue", "95");
            SettingsKeys.Add("TransferPokemonKeepAmountHighestCP", "1");
            SettingsKeys.Add("TransferPokemonKeepAmountHighestIV", "1");

            SettingsKeys.Add("UseLuckyEggs", "true");
            SettingsKeys.Add("HatchEggs", "true");
            SettingsKeys.Add("UseOnlyBasicIncubator", "true");

            SettingsKeys.Add("PrioritizeIVOverCP", "true");
            SettingsKeys.Add("ExportPokemonToCsvEveryMinutes", "15");
            SettingsKeys.Add("DebugMode", "false");
            SettingsKeys.Add("DevicePackageName", "random");
            SettingsKeys.Add("UseHumanizer", "true");

            foreach (var pair in SettingsKeys)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                if (config.AppSettings.Settings[pair.Key] == null)
                {
                    config.AppSettings.Settings.Add(pair.Key, pair.Value);
                }
                config.Save(ConfigurationSaveMode.Minimal);
            }
        }

    }
}
