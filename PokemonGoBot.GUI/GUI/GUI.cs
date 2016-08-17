using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gmap.net.Overlays;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using PokemonGoBot.GUI.GUI;
using PokemonGoBot.Logging;
using PokemonGoBot.Utils;
using POGOProtos.Map.Fort;
using RocketAPI.Exceptions;
using RocketAPI;
using RocketAPI.Helpers;

namespace PokemonGoBot.GUI
{
    public partial class Gui : Form
    {
        // That's our custom TextWriter class
        TextWriter _writer = null;

        public Gui()
        {
            InitializeComponent();
        }

        private static GMarkerGoogle _playerMarker;

        private void GUI_Load(object sender, EventArgs e)
        {
            // Instantiate the writer
            _writer = new TextBoxStreamWriter(txtConsole);
            // Redirect the out Console stream
            Console.SetOut(_writer);

            GitChecker.CheckVersion();

            Logger.Write($"Initializing Bot...");

            Button_Start.Visible = true;
            Button_Stop.Visible = false;

            ComboBox_AuthType.SelectedItem = ConfigurationManager.AppSettings["AuthType"];
            TextBox_UserNameOrEmail.Text = ConfigurationManager.AppSettings["UserNameOrEmail"];
            TextBox_UserPassword.Text = ConfigurationManager.AppSettings["UserPassword"];

            TextBot_Latitude.Text = ConfigurationManager.AppSettings["DefaultLatitude"];
            TextBot_Longitude.Text = ConfigurationManager.AppSettings["DefaultLongitude"];
            TextBot_Altitude.Text = ConfigurationManager.AppSettings["DefaultAltitude"];

            gmap.Position = new PointLatLng(Convert.ToDouble(ConfigurationManager.AppSettings["DefaultLatitude"]), Convert.ToDouble(ConfigurationManager.AppSettings["DefaultLongitude"]));

            OnOff_UseProxy.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["UseProxy"]);
            TextBox_ProxyHost.Text = ConfigurationManager.AppSettings["ProxyHost"];
            NumUpDown_ProxyPort.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["ProxyPort"]);
            TextBox_ProxyUsername.Text = ConfigurationManager.AppSettings["ProxyUsername"];
            TextBox_ProxyPassword.Text = ConfigurationManager.AppSettings["ProxyPassword"];

            OnOff_UseCSVExport.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["UseCSVExport"]);
            NumUpDown_CSVExportInMinutes.Value =
                Convert.ToDecimal(ConfigurationManager.AppSettings["CSVExportInMinutes"]);

            ComboBox_MovementType.SelectedItem = ConfigurationManager.AppSettings["MovementBy"];
            NumUpDown_WalkingSpeed.Value =
                Convert.ToDecimal(ConfigurationManager.AppSettings["WalkingSpeedInKilometerPerHour"]);
            NumUpDown_MaxTravelDistance.Value =
                Convert.ToDecimal(ConfigurationManager.AppSettings["MaxTravelDistanceInMeters"]);

            TextBot_GPXFile.Text = ConfigurationManager.AppSettings["GPXFile"];
            OnOff_GPXIgnorePokestops.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["GPXIgnorePokestops"]);

            OnOff_CatchMapPokemon.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["CatchMapPokemon"]);
            OnOff_CatchIncensePokemon.Checked =
                Convert.ToBoolean(ConfigurationManager.AppSettings["CatchIncensePokemon"]);
            OnOff_CatchLuredPokemon.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["CatchLuredPokemon"]);
            OnOff_ToNotCatchList.Checked =
                Convert.ToBoolean(ConfigurationManager.AppSettings["UsePokemonToNotCatchList"]);
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["PokemonToNotCatchList"]))
            {
                ConfigurationManager.AppSettings["PokemonToNotCatchList"].Split(',')
                    .ToList()
                    .ForEach(item =>
                    {
                        var index = checkedList_ToNotCatchList.Items.IndexOf(item);
                        checkedList_ToNotCatchList.SetItemChecked(index, true);
                    });
            }

            OnOff_EvolvePokemon.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["EvolvePokemon"]);
            OnOff_ToEvolveList.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["UsePokemonToEvolveList"]);
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["PokemonToEvolveList"]))
            {
                ConfigurationManager.AppSettings["PokemonToEvolveList"].Split(',')
                    .ToList()
                    .ForEach(item =>
                    {
                        var index = checkedList_ToEvolveList.Items.IndexOf(item);
                        checkedList_ToEvolveList.SetItemChecked(index, true);
                    });
            }

            OnOff_TransferPokemon.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["TransferPokemon"]);
            OnOff_ToNotTransferList.Checked =
                Convert.ToBoolean(ConfigurationManager.AppSettings["UsePokemonToNotTransferList"]);
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["PokemonToNotTransferList"]))
            {
                ConfigurationManager.AppSettings["PokemonToNotTransferList"].Split(',')
                    .ToList()
                    .ForEach(item =>
                    {
                        var index = checkedList_ToNotTransferList.Items.IndexOf(item);
                        checkedList_ToNotTransferList.SetItemChecked(index, true);
                    });
            }

            ComboBox_DeviceType.SelectedItem = ConfigurationManager.AppSettings["DeviceType"];
            ComboBox_PreconfiguredDevices.SelectedItem = ConfigurationManager.AppSettings["DevicePackageName"];
            if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["DeviceId"]) || ConfigurationManager.AppSettings["DeviceId"] == "8525f5d8201f78b5")
                ConfigurationManager.AppSettings["DeviceId"] = RandomHelper.RandomString(16, "0123456789abcdef");
            TextBox_DeviceId.Text = ConfigurationManager.AppSettings["DeviceId"];
            TextBox_AndroidBoardName.Text = ConfigurationManager.AppSettings["AndroidBoardName"];
            TextBox_AndroidBootloader.Text = ConfigurationManager.AppSettings["AndroidBootloader"];
            TextBox_DeviceBrand.Text = ConfigurationManager.AppSettings["DeviceBrand"];
            TextBox_DeviceModel.Text = ConfigurationManager.AppSettings["DeviceModel"];
            TextBox_DeviceModelIdentifier.Text = ConfigurationManager.AppSettings["DeviceModelIdentifier"];
            TextBox_DeviceModelBoot.Text = ConfigurationManager.AppSettings["DeviceModelBoot"];
            TextBox_HardwareManufacturer.Text = ConfigurationManager.AppSettings["HardwareManufacturer"];
            TextBox_HardwareModel.Text = ConfigurationManager.AppSettings["HardwareModel"];
            TextBox_FirmwareBrand.Text = ConfigurationManager.AppSettings["FirmwareBrand"];
            TextBox_FirmwareTags.Text = ConfigurationManager.AppSettings["FirmwareTags"];
            TextBox_FirmwareType.Text = ConfigurationManager.AppSettings["FirmwareType"];
            TextBox_FirmwareFingerprint.Text = ConfigurationManager.AppSettings["FirmwareFingerprint"];

            OnOff_LogOut_Runtime.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["LogOut_Runtime"]);
            NumUpDown_LogOut_Runtime.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["LogOut_Runtime_Value"]);
            OnOff_LogOut_LevelReached.Checked =
                Convert.ToBoolean(ConfigurationManager.AppSettings["LogOut_LevelReached"]);
            NumUpDown_LogOut_LevelReached.Value =
                Convert.ToDecimal(ConfigurationManager.AppSettings["LogOut_LevelReached_Value"]);
            OnOff_LogOut_PokemonCaught.Checked =
                Convert.ToBoolean(ConfigurationManager.AppSettings["LogOut_PokemonCaught"]);
            NumUpDown_LogOut_PokemonCaught.Value =
                Convert.ToDecimal(ConfigurationManager.AppSettings["LogOut_PokemonCaught_Value"]);
            OnOff_LogOut_PokestopsVisit.Checked =
                Convert.ToBoolean(ConfigurationManager.AppSettings["LogOut_PokestopsVisit"]);
            NumUpDown_LogOut_PokestopsVisit.Value =
                Convert.ToDecimal(ConfigurationManager.AppSettings["LogOut_PokestopsVisit_Value"]);

            OnOff_DebugMode.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["DebugMode"]);

            Logger.Write($"Initializing Bot completed...");
        }

        private void Settings_Save_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["AuthType"].Value = ComboBox_AuthType.SelectedItem.ToString();
            config.AppSettings.Settings["UserNameOrEmail"].Value = TextBox_UserNameOrEmail.Text;
            config.AppSettings.Settings["UserPassword"].Value = TextBox_UserPassword.Text;

            config.AppSettings.Settings["DefaultLatitude"].Value = TextBot_Latitude.Text;
            config.AppSettings.Settings["DefaultLongitude"].Value = TextBot_Longitude.Text;
            config.AppSettings.Settings["DefaultAltitude"].Value = TextBot_Altitude.Text;

            config.AppSettings.Settings["UseProxy"].Value = OnOff_UseProxy.Checked.ToString();
            config.AppSettings.Settings["ProxyHost"].Value = TextBox_ProxyHost.Text;
            config.AppSettings.Settings["ProxyPort"].Value = NumUpDown_ProxyPort.Value.ToString();
            config.AppSettings.Settings["ProxyUsername"].Value = TextBox_ProxyUsername.Text;
            config.AppSettings.Settings["ProxyPassword"].Value = TextBox_ProxyPassword.Text;

            config.AppSettings.Settings["UseCSVExport"].Value = OnOff_UseCSVExport.Checked.ToString();
            config.AppSettings.Settings["CSVExportInMinutes"].Value = NumUpDown_CSVExportInMinutes.Value.ToString();

            config.AppSettings.Settings["MovementBy"].Value = ComboBox_MovementType.SelectedItem.ToString();
            config.AppSettings.Settings["WalkingSpeedInKilometerPerHour"].Value =
                NumUpDown_WalkingSpeed.Value.ToString();
            config.AppSettings.Settings["MaxTravelDistanceInMeters"].Value =
                NumUpDown_MaxTravelDistance.Value.ToString();

            config.AppSettings.Settings["GPXFile"].Value = TextBot_GPXFile.Text;
            config.AppSettings.Settings["GPXIgnorePokestops"].Value = OnOff_GPXIgnorePokestops.Checked.ToString();

            config.AppSettings.Settings["CatchMapPokemon"].Value = OnOff_CatchMapPokemon.Checked.ToString();
            config.AppSettings.Settings["CatchIncensePokemon"].Value = OnOff_CatchIncensePokemon.Checked.ToString();
            config.AppSettings.Settings["CatchLuredPokemon"].Value = OnOff_CatchLuredPokemon.Checked.ToString();
            config.AppSettings.Settings["UsePokemonToNotCatchList"].Value = OnOff_ToNotCatchList.Checked.ToString();
            config.AppSettings.Settings["PokemonToNotCatchList"].Value = string.Join(",",
                checkedList_ToNotCatchList.CheckedItems.Cast<string>().ToArray());

            config.AppSettings.Settings["EvolvePokemon"].Value = OnOff_EvolvePokemon.Checked.ToString();
            config.AppSettings.Settings["UsePokemonToEvolveList"].Value = OnOff_ToEvolveList.Checked.ToString();
            config.AppSettings.Settings["PokemonToEvolveList"].Value = string.Join(",",
                checkedList_ToEvolveList.CheckedItems.Cast<string>().ToArray());

            config.AppSettings.Settings["TransferPokemon"].Value = OnOff_TransferPokemon.Checked.ToString();
            config.AppSettings.Settings["UsePokemonToNotTransferList"].Value =
                OnOff_ToNotTransferList.Checked.ToString();
            config.AppSettings.Settings["PokemonToNotTransferList"].Value = string.Join(",",
                checkedList_ToNotTransferList.CheckedItems.Cast<string>().ToArray());

            config.AppSettings.Settings["DeviceType"].Value = ComboBox_DeviceType.SelectedItem.ToString();
            if (ComboBox_PreconfiguredDevices.SelectedItem.ToString() != null)
                config.AppSettings.Settings["DevicePackageName"].Value =
                    ComboBox_PreconfiguredDevices.SelectedItem.ToString();
            if (string.IsNullOrEmpty(TextBox_DeviceId.Text) || TextBox_DeviceId.Text == "8525f5d8201f78b5")
                TextBox_DeviceId.Text = RandomHelper.RandomString(16, "0123456789abcdef");
            config.AppSettings.Settings["DeviceId"].Value = TextBox_DeviceId.Text;
            config.AppSettings.Settings["AndroidBoardName"].Value = TextBox_AndroidBoardName.Text;
            config.AppSettings.Settings["AndroidBootloader"].Value = TextBox_AndroidBootloader.Text;
            config.AppSettings.Settings["DeviceBrand"].Value = TextBox_DeviceBrand.Text;
            config.AppSettings.Settings["DeviceModel"].Value = TextBox_DeviceModel.Text;
            config.AppSettings.Settings["DeviceModelIdentifier"].Value = TextBox_DeviceModelIdentifier.Text;
            config.AppSettings.Settings["DeviceModelBoot"].Value = TextBox_DeviceModelBoot.Text;
            config.AppSettings.Settings["HardwareManufacturer"].Value = TextBox_HardwareManufacturer.Text;
            config.AppSettings.Settings["HardwareModel"].Value = TextBox_HardwareModel.Text;
            config.AppSettings.Settings["FirmwareBrand"].Value = TextBox_FirmwareBrand.Text;
            config.AppSettings.Settings["FirmwareTags"].Value = TextBox_FirmwareTags.Text;
            config.AppSettings.Settings["FirmwareType"].Value = TextBox_FirmwareType.Text;
            config.AppSettings.Settings["FirmwareFingerprint"].Value = TextBox_FirmwareFingerprint.Text;

            config.AppSettings.Settings["LogOut_Runtime"].Value = OnOff_LogOut_Runtime.Checked.ToString();
            config.AppSettings.Settings["LogOut_Runtime_Value"].Value = NumUpDown_LogOut_Runtime.Value.ToString();
            config.AppSettings.Settings["LogOut_LevelReached"].Value = OnOff_LogOut_LevelReached.Checked.ToString();
            config.AppSettings.Settings["LogOut_LevelReached_Value"].Value =
                NumUpDown_LogOut_LevelReached.Value.ToString();
            config.AppSettings.Settings["LogOut_PokemonCaught"].Value = OnOff_LogOut_PokemonCaught.Checked.ToString();
            config.AppSettings.Settings["LogOut_PokemonCaught_Value"].Value =
                NumUpDown_LogOut_PokemonCaught.Value.ToString();
            config.AppSettings.Settings["LogOut_PokestopsVisit"].Value = OnOff_LogOut_PokestopsVisit.Checked.ToString();
            config.AppSettings.Settings["LogOut_PokestopsVisit_Value"].Value =
                NumUpDown_LogOut_PokestopsVisit.Value.ToString();

            config.AppSettings.Settings["DebugMode"].Value = OnOff_DebugMode.Checked.ToString();

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void Bot_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nsGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void nsTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nsTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_SelectGPXFile_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                TextBot_GPXFile.Text = fileToOpen;
            }
        }

        private void checkedList_ToNotCatchList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_EvolveListSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedList_ToEvolveList.Items.Count; i++)
                checkedList_ToEvolveList.SetItemChecked(i, true);
        }

        private void Button_EvolveListUnselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedList_ToEvolveList.Items.Count; i++)
                checkedList_ToEvolveList.SetItemChecked(i, false);
        }

        private void Button_TransferListSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedList_ToNotTransferList.Items.Count; i++)
                checkedList_ToNotTransferList.SetItemChecked(i, true);
        }

        private void Button_TransferListUnselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedList_ToNotTransferList.Items.Count; i++)
                checkedList_ToNotTransferList.SetItemChecked(i, false);
        }

        private void Button_CatchListSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedList_ToNotCatchList.Items.Count; i++)
                checkedList_ToNotCatchList.SetItemChecked(i, true);
        }

        private void Button_CatchListUnselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedList_ToNotCatchList.Items.Count; i++)
                checkedList_ToNotCatchList.SetItemChecked(i, false);
        }

        private void nsComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private async void Button_Start_Click(object sender, EventArgs e)
        {
            Settings.Settings.cancellationTokenSource = new CancellationTokenSource();
            Settings.Settings.cancellationToken = Settings.Settings.cancellationTokenSource.Token;

            Button_Start.Visible = false;
            Button_Stop.Visible = true;

            Logger.Write($"Bot started");
            await Run();
        }

        private async Task Run()
        {
            var task = new Task(() => {
                try
                {
                    new Logic(new Settings.Settings()).Execute(Settings.Settings.cancellationToken).Wait(Settings.Settings.cancellationToken);
                }
                catch (AggregateException ae)
                {
                    throw ae.Flatten().InnerException;
                }
                catch (OperationCanceledException)
                {
                    Logger.Write($"Bot stopped");
                    Button_Stop.Visible = false;
                    Button_Start.Visible = true;
                }
                catch (Exception ex)
                {
                    Logger.Write($"Unhandled exception: {ex}", LogLevel.Error);
                    new Logic(new Settings.Settings()).Execute(Settings.Settings.cancellationToken).Wait(Settings.Settings.cancellationToken);
                }
            }, Settings.Settings.cancellationToken);
            task.Start();
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            Settings.Settings.cancellationTokenSource.Cancel();
            Button_Stop.Visible = false;
            Button_Start.Visible = true;
        }

        private void nsLabel19_Click(object sender, EventArgs e)
        {

        }

        private void gmap_Load(object sender, EventArgs e)
        {
            // Initialize map:
            gmap.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(52.371063, 4.898526);
        }

        public static void SetPokestopMarker(List<FortData>pokestops)
        {
            GMapOverlay markersOverlay = new GMapOverlay("Pokestops");
            foreach (var pokestop in pokestops)
            {
                //Name Overlay disabled...currently to heavy Requests per second
                //var fortInfo = await Logic._client.Fort.GetFort(pokestop.Id, pokestop.Latitude, pokestop.Longitude);
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(pokestop.Latitude, pokestop.Longitude), GMarkerGoogleType.blue);
                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                //marker.ToolTipText = $"{fortInfo.Name}";
                //marker.ToolTipText = $"Test";
                markersOverlay.Markers.Add(marker);
            }
            gmap.Overlays.Add(markersOverlay);
        }

        public static void UpdatePlayerLocation(double latitude, double longitude)
        {
            if (_playerMarker == null)
            {
                GMapOverlay playerOverlay = new GMapOverlay("Player");
                Bitmap playerImg = new Bitmap(Image.FromFile("e:\\Player.png"), new Size(32, 32));

                _playerMarker = new GMarkerGoogle(gmap.Position, playerImg);
                playerOverlay.Markers.Add(_playerMarker);
                gmap.Overlays.Add(playerOverlay);
            }
            gmap.Position = new PointLatLng(latitude, longitude);
            _playerMarker.Position = gmap.Position;
        }

        private void Button_NewDeviceId_Click(object sender, EventArgs e)
        {
            TextBox_DeviceId.Text = ConfigurationManager.AppSettings["DeviceId"] = RandomHelper.RandomString(16, "0123456789abcdef");
        }
    }
}
