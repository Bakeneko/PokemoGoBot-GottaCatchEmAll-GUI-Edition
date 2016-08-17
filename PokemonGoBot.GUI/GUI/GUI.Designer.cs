using System.Windows.Forms;
using PokemonGoBot.GUI.GUI.Theme;

namespace PokemonGoBot.GUI
{
    partial class Gui
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nsTheme1 = new PokemonGoBot.GUI.GUI.Theme.NSTheme();
            this.Button_Stop = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.Bot_Close = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.Button_Start = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.Settings_Save = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.OnlyForDonators_Text = new System.Windows.Forms.Label();
            this.OnOff_DebugMode = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.Debug_Label = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TabControl_Main = new PokemonGoBot.GUI.GUI.Theme.NSTabControl();
            this.TabPage_Main = new System.Windows.Forms.TabPage();
            gmap = new GMap.NET.WindowsForms.GMapControl();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.GroupBox_Statistics = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.nsLabel19 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel18 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel14 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel17 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel16 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel15 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel13 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel12 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel11 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel10 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel9 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel8 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel7 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel6 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.TabPage_Pokemon = new System.Windows.Forms.TabPage();
            this.TabPage_Inventory = new System.Windows.Forms.TabPage();
            this.TabPage_Settings = new System.Windows.Forms.TabPage();
            this.nsTabControl1 = new PokemonGoBot.GUI.GUI.Theme.NSTabControl();
            this.Tab_Settings_Page_GeneralSettings = new System.Windows.Forms.TabPage();
            this.GroupBox_CSVExpot = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.NumUpDown_CSVExportInMinutes = new System.Windows.Forms.NumericUpDown();
            this.OnOff_UseCSVExport = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.nsLabel1 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.GroupBox_Proxy = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.NumUpDown_ProxyPort = new System.Windows.Forms.NumericUpDown();
            this.Label_ProxyPassword = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_ProxyUsername = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_ProxyPort = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_ProxyHost = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.TextBox_ProxyPassword = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_ProxyUsername = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_ProxyHost = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.OnOff_UseProxy = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.GroupBox_Coordinates = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.Label_DefaultAltitude = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_DefaultLongitude = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_DefaultLatitude = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.TextBot_Altitude = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBot_Longitude = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBot_Latitude = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.GroupBox_Login = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.TextBox_UserPassword = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_UserNameOrEmail = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.ComboBox_AuthType = new PokemonGoBot.GUI.GUI.Theme.NSComboBox();
            this.Tab_Settings_Page_MovementSettings = new System.Windows.Forms.TabPage();
            this.GroupBox_GPXPathing = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.OnOff_GPXIgnorePokestops = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.TextBot_GPXFile = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.Button_SelectGPXFile = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.Label_GPXIgnorePokestops = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_GPXFile = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsGroupBox1 = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.NumUpDown_WalkingSpeed = new System.Windows.Forms.NumericUpDown();
            this.NumUpDown_MaxTravelDistance = new System.Windows.Forms.NumericUpDown();
            this.Label_MaxTravelDistance = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_WalkingSpeed = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.ComboBox_MovementType = new PokemonGoBot.GUI.GUI.Theme.NSComboBox();
            this.Tab_Settings_Page_CatchSettings = new System.Windows.Forms.TabPage();
            this.nsGroupBox5 = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.nsGroupBox4 = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.GroupBox_ToNotCatchList = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.Button_CatchListUnselectAll = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.Button_CatchListSelectAll = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.OnOff_ToNotCatchList = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.checkedList_ToNotCatchList = new System.Windows.Forms.CheckedListBox();
            this.GroupBox_CatchPokemon = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.Label_CatchLuredPokemon = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_CatchIncensePokemon = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_CatchMapPokemon = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.OnOff_CatchLuredPokemon = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.OnOff_CatchIncensePokemon = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.OnOff_CatchMapPokemon = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.Tab_Settings_Page_EvolveSettings = new System.Windows.Forms.TabPage();
            this.GroupBox_EvolvePokemon = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.nsLabel2 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.nsLabel24 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel23 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.OnOff_EvolvePokemon = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.GroupBox_ToEvolveList = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.Button_EvolveListUnselectAll = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.Button_EvolveListSelectAll = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.OnOff_ToEvolveList = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.checkedList_ToEvolveList = new System.Windows.Forms.CheckedListBox();
            this.Tab_Settings_Page_TransferSettings = new System.Windows.Forms.TabPage();
            this.GroupBox_TransferPokemon = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.OnOff_TransferPokemon = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.GroupBox_ToNotTransferList = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.Button_TransferListUnselectAll = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.Button_TransferListSelectAll = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.OnOff_ToNotTransferList = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.checkedList_ToNotTransferList = new System.Windows.Forms.CheckedListBox();
            this.Tab_Settings_Page_InventorySettings = new System.Windows.Forms.TabPage();
            this.Tab_Settings_Page_UseItemsSettings = new System.Windows.Forms.TabPage();
            this.nsGroupBox3 = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.nsOnOffBox3 = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.nsLabel4 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsOnOffBox2 = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.nsGroupBox2 = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.nsOnOffBox1 = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.Tab_Settings_Page_SecuritySettings = new System.Windows.Forms.TabPage();
            this.GroupBox_LogOut = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.NumUpDown_LogOut_Runtime = new System.Windows.Forms.NumericUpDown();
            this.Label_LogOut_Runtime = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.OnOff_LogOut_Runtime = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.NumUpDown_LogOut_PokestopsVisit = new System.Windows.Forms.NumericUpDown();
            this.NumUpDown_LogOut_PokemonCaught = new System.Windows.Forms.NumericUpDown();
            this.NumUpDown_LogOut_LevelReached = new System.Windows.Forms.NumericUpDown();
            this.Label_LogOut_PokestopsVisit = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.OnOff_LogOut_PokestopsVisit = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.Label_LogOut_PokemonCaught = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.OnOff_LogOut_PokemonCaught = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.OnOff_LogOut_LevelReached = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.Label_LogOut_LevelReached = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.GroupBox_DeviceSettings = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.Button_NewDeviceId = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.Label_DeviceBrand = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.TextBox_DeviceBrand = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_FirmwareFingerprint = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.Label_AndroidBoardName = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_AndroidBootloader = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.TextBox_FirmwareType = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_FirmwareTags = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_FirmwareBrand = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_HardwareModel = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_HardwareManufacturer = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_DeviceModelBoot = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_DeviceModelIdentifier = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_DeviceModel = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_AndroidBootloader = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_AndroidBoardName = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TextBox_DeviceId = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_PreconfiguredDevices = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.ComboBox_PreconfiguredDevices = new PokemonGoBot.GUI.GUI.Theme.NSComboBox();
            this.Label_FirmwareFingerprint = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_FirmwareType = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_FirmwareTags = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_FirmwareBrand = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_HardwareModel = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_HardwareManufacturer = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_DeviceModelBoot = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_DeviceModelIdentifier = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_DeviceModel = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_DeviceId = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.ComboBox_DeviceType = new PokemonGoBot.GUI.GUI.Theme.NSComboBox();
            this.nsTheme1.SuspendLayout();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Main.SuspendLayout();
            this.GroupBox_Statistics.SuspendLayout();
            this.TabPage_Settings.SuspendLayout();
            this.nsTabControl1.SuspendLayout();
            this.Tab_Settings_Page_GeneralSettings.SuspendLayout();
            this.GroupBox_CSVExpot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_CSVExportInMinutes)).BeginInit();
            this.GroupBox_Proxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_ProxyPort)).BeginInit();
            this.GroupBox_Coordinates.SuspendLayout();
            this.GroupBox_Login.SuspendLayout();
            this.Tab_Settings_Page_MovementSettings.SuspendLayout();
            this.GroupBox_GPXPathing.SuspendLayout();
            this.nsGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_WalkingSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_MaxTravelDistance)).BeginInit();
            this.Tab_Settings_Page_CatchSettings.SuspendLayout();
            this.GroupBox_ToNotCatchList.SuspendLayout();
            this.GroupBox_CatchPokemon.SuspendLayout();
            this.Tab_Settings_Page_EvolveSettings.SuspendLayout();
            this.GroupBox_EvolvePokemon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.GroupBox_ToEvolveList.SuspendLayout();
            this.Tab_Settings_Page_TransferSettings.SuspendLayout();
            this.GroupBox_TransferPokemon.SuspendLayout();
            this.GroupBox_ToNotTransferList.SuspendLayout();
            this.Tab_Settings_Page_UseItemsSettings.SuspendLayout();
            this.nsGroupBox3.SuspendLayout();
            this.nsGroupBox2.SuspendLayout();
            this.Tab_Settings_Page_SecuritySettings.SuspendLayout();
            this.GroupBox_LogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_LogOut_Runtime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_LogOut_PokestopsVisit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_LogOut_PokemonCaught)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_LogOut_LevelReached)).BeginInit();
            this.GroupBox_DeviceSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new PokemonGoBot.GUI.GUI.Theme.Bloom[0];
            this.nsTheme1.Controls.Add(this.Button_Stop);
            this.nsTheme1.Controls.Add(this.Bot_Close);
            this.nsTheme1.Controls.Add(this.Button_Start);
            this.nsTheme1.Controls.Add(this.Settings_Save);
            this.nsTheme1.Controls.Add(this.OnlyForDonators_Text);
            this.nsTheme1.Controls.Add(this.OnOff_DebugMode);
            this.nsTheme1.Controls.Add(this.Debug_Label);
            this.nsTheme1.Controls.Add(this.TabControl_Main);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = ((System.Drawing.Image)(resources.GetObject("nsTheme1.Image")));
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(900, 500);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "Pokemon GO Bot - Gotta Catch \'Em All - GUI Edition // Version: 2016.8.15.386";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            // 
            // Button_Stop
            // 
            this.Button_Stop.Location = new System.Drawing.Point(607, 468);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(42, 23);
            this.Button_Stop.TabIndex = 3;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Bot_Close
            // 
            this.Bot_Close.Location = new System.Drawing.Point(844, 468);
            this.Bot_Close.Name = "Bot_Close";
            this.Bot_Close.Size = new System.Drawing.Size(44, 23);
            this.Bot_Close.TabIndex = 7;
            this.Bot_Close.Text = "Close";
            this.Bot_Close.Click += new System.EventHandler(this.Bot_Close_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(559, 468);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(42, 23);
            this.Button_Start.TabIndex = 2;
            this.Button_Start.Text = "Start";
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Settings_Save
            // 
            this.Settings_Save.Location = new System.Drawing.Point(796, 468);
            this.Settings_Save.Name = "Settings_Save";
            this.Settings_Save.Size = new System.Drawing.Size(42, 23);
            this.Settings_Save.TabIndex = 6;
            this.Settings_Save.Text = "Save";
            this.Settings_Save.Click += new System.EventHandler(this.Settings_Save_Click);
            // 
            // OnlyForDonators_Text
            // 
            this.OnlyForDonators_Text.AutoSize = true;
            this.OnlyForDonators_Text.Location = new System.Drawing.Point(12, 478);
            this.OnlyForDonators_Text.Name = "OnlyForDonators_Text";
            this.OnlyForDonators_Text.Size = new System.Drawing.Size(270, 13);
            this.OnlyForDonators_Text.TabIndex = 5;
            this.OnlyForDonators_Text.Text = "✔ This functions is only available for Donators";
            // 
            // OnOff_DebugMode
            // 
            this.OnOff_DebugMode.Checked = false;
            this.OnOff_DebugMode.Location = new System.Drawing.Point(832, 34);
            this.OnOff_DebugMode.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_DebugMode.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_DebugMode.Name = "OnOff_DebugMode";
            this.OnOff_DebugMode.Size = new System.Drawing.Size(56, 24);
            this.OnOff_DebugMode.TabIndex = 2;
            this.OnOff_DebugMode.Text = "OnOff_DebugMode";
            this.OnOff_DebugMode.CheckedChanged += new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox.CheckedChangedEventHandler(this.OnOff_DebugMode_CheckedChanged);
            // 
            // Debug_Label
            // 
            this.Debug_Label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Debug_Label.Enabled = false;
            this.Debug_Label.Location = new System.Drawing.Point(783, 35);
            this.Debug_Label.MaxLength = 32767;
            this.Debug_Label.Multiline = false;
            this.Debug_Label.Name = "Debug_Label";
            this.Debug_Label.ReadOnly = false;
            this.Debug_Label.Size = new System.Drawing.Size(43, 23);
            this.Debug_Label.TabIndex = 1;
            this.Debug_Label.Text = "Debug";
            this.Debug_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Debug_Label.UseSystemPasswordChar = false;
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControl_Main.Controls.Add(this.TabPage_Main);
            this.TabControl_Main.Controls.Add(this.TabPage_Pokemon);
            this.TabControl_Main.Controls.Add(this.TabPage_Inventory);
            this.TabControl_Main.Controls.Add(this.TabPage_Settings);
            this.TabControl_Main.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl_Main.ItemSize = new System.Drawing.Size(28, 80);
            this.TabControl_Main.Location = new System.Drawing.Point(12, 63);
            this.TabControl_Main.Multiline = true;
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(876, 399);
            this.TabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl_Main.TabIndex = 0;
            // 
            // TabPage_Main
            // 
            this.TabPage_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage_Main.Controls.Add(gmap);
            this.TabPage_Main.Controls.Add(this.txtConsole);
            this.TabPage_Main.Controls.Add(this.GroupBox_Statistics);
            this.TabPage_Main.Location = new System.Drawing.Point(84, 4);
            this.TabPage_Main.Name = "TabPage_Main";
            this.TabPage_Main.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Main.Size = new System.Drawing.Size(788, 391);
            this.TabPage_Main.TabIndex = 0;
            this.TabPage_Main.Text = "Main";
            // 
            // gmap
            // 
            gmap.AccessibleDescription = "gmap";
            gmap.AccessibleName = "gmap";
            gmap.Bearing = 0F;
            gmap.CanDragMap = true;
            gmap.EmptyTileColor = System.Drawing.Color.Navy;
            gmap.GrayScaleMode = false;
            gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gmap.LevelsKeepInMemmory = 5;
            gmap.Location = new System.Drawing.Point(426, 6);
            gmap.MarkersEnabled = true;
            gmap.MaxZoom = 18;
            gmap.MinZoom = 2;
            gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            gmap.Name = "gmap";
            gmap.NegativeMode = false;
            gmap.PolygonsEnabled = true;
            gmap.RetryLoadTile = 0;
            gmap.RoutesEnabled = true;
            gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            gmap.ShowTileGridLines = false;
            gmap.Size = new System.Drawing.Size(356, 230);
            gmap.TabIndex = 2;
            gmap.Zoom = 16D;
            gmap.Load += new System.EventHandler(gmap_Load);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(6, 241);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(776, 144);
            this.txtConsole.TabIndex = 1;
            // 
            // GroupBox_Statistics
            // 
            this.GroupBox_Statistics.Controls.Add(this.nsLabel19);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel18);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel14);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel17);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel16);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel15);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel13);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel12);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel11);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel10);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel9);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel8);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel7);
            this.GroupBox_Statistics.Controls.Add(this.nsLabel6);
            this.GroupBox_Statistics.DrawSeperator = false;
            this.GroupBox_Statistics.Location = new System.Drawing.Point(6, 6);
            this.GroupBox_Statistics.Name = "GroupBox_Statistics";
            this.GroupBox_Statistics.Size = new System.Drawing.Size(414, 230);
            this.GroupBox_Statistics.SubTitle = "Details";
            this.GroupBox_Statistics.TabIndex = 0;
            this.GroupBox_Statistics.Text = "GroupBox_Statistics";
            this.GroupBox_Statistics.Title = "Statistics";
            // 
            // nsLabel19
            // 
            this.nsLabel19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel19.Location = new System.Drawing.Point(3, 208);
            this.nsLabel19.Name = "nsLabel19";
            this.nsLabel19.Size = new System.Drawing.Size(117, 15);
            this.nsLabel19.TabIndex = 17;
            this.nsLabel19.Text = "nsLabel19";
            this.nsLabel19.Value1 = "Items";
            this.nsLabel19.Value2 = "Recycled";
            this.nsLabel19.Click += new System.EventHandler(this.nsLabel19_Click);
            // 
            // nsLabel18
            // 
            this.nsLabel18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel18.Location = new System.Drawing.Point(207, 40);
            this.nsLabel18.Name = "nsLabel18";
            this.nsLabel18.Size = new System.Drawing.Size(101, 15);
            this.nsLabel18.TabIndex = 16;
            this.nsLabel18.Text = "nsLabel18";
            this.nsLabel18.Value1 = "LevelUp";
            this.nsLabel18.Value2 = "in";
            // 
            // nsLabel14
            // 
            this.nsLabel14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel14.Location = new System.Drawing.Point(207, 208);
            this.nsLabel14.Name = "nsLabel14";
            this.nsLabel14.Size = new System.Drawing.Size(154, 15);
            this.nsLabel14.TabIndex = 12;
            this.nsLabel14.Text = "nsLabel14";
            this.nsLabel14.Value1 = "Km Walked";
            this.nsLabel14.Value2 = "(this Session)";
            // 
            // nsLabel17
            // 
            this.nsLabel17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel17.Location = new System.Drawing.Point(207, 145);
            this.nsLabel17.Name = "nsLabel17";
            this.nsLabel17.Size = new System.Drawing.Size(101, 15);
            this.nsLabel17.TabIndex = 15;
            this.nsLabel17.Text = "nsLabel17";
            this.nsLabel17.Value1 = "per";
            this.nsLabel17.Value2 = "Hour";
            // 
            // nsLabel16
            // 
            this.nsLabel16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel16.Location = new System.Drawing.Point(3, 61);
            this.nsLabel16.Name = "nsLabel16";
            this.nsLabel16.Size = new System.Drawing.Size(101, 15);
            this.nsLabel16.TabIndex = 14;
            this.nsLabel16.Text = "nsLabel16";
            this.nsLabel16.Value1 = "Current";
            this.nsLabel16.Value2 = "Experience";
            // 
            // nsLabel15
            // 
            this.nsLabel15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel15.Location = new System.Drawing.Point(207, 61);
            this.nsLabel15.Name = "nsLabel15";
            this.nsLabel15.Size = new System.Drawing.Size(101, 15);
            this.nsLabel15.TabIndex = 13;
            this.nsLabel15.Text = "nsLabel15";
            this.nsLabel15.Value1 = "per";
            this.nsLabel15.Value2 = "Hour";
            // 
            // nsLabel13
            // 
            this.nsLabel13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel13.Location = new System.Drawing.Point(207, 82);
            this.nsLabel13.Name = "nsLabel13";
            this.nsLabel13.Size = new System.Drawing.Size(101, 15);
            this.nsLabel13.TabIndex = 11;
            this.nsLabel13.Text = "nsLabel13";
            this.nsLabel13.Value1 = "per";
            this.nsLabel13.Value2 = "Hour";
            // 
            // nsLabel12
            // 
            this.nsLabel12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel12.Location = new System.Drawing.Point(3, 187);
            this.nsLabel12.Name = "nsLabel12";
            this.nsLabel12.Size = new System.Drawing.Size(117, 15);
            this.nsLabel12.TabIndex = 10;
            this.nsLabel12.Text = "nsLabel12";
            this.nsLabel12.Value1 = "Pokemon";
            this.nsLabel12.Value2 = "Transferred";
            // 
            // nsLabel11
            // 
            this.nsLabel11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel11.Location = new System.Drawing.Point(3, 166);
            this.nsLabel11.Name = "nsLabel11";
            this.nsLabel11.Size = new System.Drawing.Size(101, 15);
            this.nsLabel11.TabIndex = 9;
            this.nsLabel11.Text = "nsLabel11";
            this.nsLabel11.Value1 = "Pokemon";
            this.nsLabel11.Value2 = "Evolved";
            // 
            // nsLabel10
            // 
            this.nsLabel10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel10.Location = new System.Drawing.Point(3, 145);
            this.nsLabel10.Name = "nsLabel10";
            this.nsLabel10.Size = new System.Drawing.Size(101, 15);
            this.nsLabel10.TabIndex = 8;
            this.nsLabel10.Text = "nsLabel10";
            this.nsLabel10.Value1 = "Pokemon";
            this.nsLabel10.Value2 = "Caught";
            // 
            // nsLabel9
            // 
            this.nsLabel9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel9.Location = new System.Drawing.Point(3, 82);
            this.nsLabel9.Name = "nsLabel9";
            this.nsLabel9.Size = new System.Drawing.Size(101, 15);
            this.nsLabel9.TabIndex = 7;
            this.nsLabel9.Text = "nsLabel9";
            this.nsLabel9.Value1 = "Current";
            this.nsLabel9.Value2 = "Stardust";
            // 
            // nsLabel8
            // 
            this.nsLabel8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel8.Location = new System.Drawing.Point(3, 103);
            this.nsLabel8.Name = "nsLabel8";
            this.nsLabel8.Size = new System.Drawing.Size(101, 15);
            this.nsLabel8.TabIndex = 6;
            this.nsLabel8.Text = "nsLabel8";
            this.nsLabel8.Value1 = "Current";
            this.nsLabel8.Value2 = "Pokemon";
            // 
            // nsLabel7
            // 
            this.nsLabel7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel7.Location = new System.Drawing.Point(3, 124);
            this.nsLabel7.Name = "nsLabel7";
            this.nsLabel7.Size = new System.Drawing.Size(101, 15);
            this.nsLabel7.TabIndex = 5;
            this.nsLabel7.Text = "nsLabel7";
            this.nsLabel7.Value1 = "Current";
            this.nsLabel7.Value2 = "PokeDex";
            // 
            // nsLabel6
            // 
            this.nsLabel6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel6.Location = new System.Drawing.Point(3, 40);
            this.nsLabel6.Name = "nsLabel6";
            this.nsLabel6.Size = new System.Drawing.Size(101, 15);
            this.nsLabel6.TabIndex = 4;
            this.nsLabel6.Text = "nsLabel6";
            this.nsLabel6.Value1 = "Current";
            this.nsLabel6.Value2 = "Level";
            // 
            // TabPage_Pokemon
            // 
            this.TabPage_Pokemon.AllowDrop = true;
            this.TabPage_Pokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage_Pokemon.Location = new System.Drawing.Point(84, 4);
            this.TabPage_Pokemon.Name = "TabPage_Pokemon";
            this.TabPage_Pokemon.Size = new System.Drawing.Size(788, 391);
            this.TabPage_Pokemon.TabIndex = 2;
            this.TabPage_Pokemon.Text = "Pokemon";
            // 
            // TabPage_Inventory
            // 
            this.TabPage_Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage_Inventory.Location = new System.Drawing.Point(84, 4);
            this.TabPage_Inventory.Name = "TabPage_Inventory";
            this.TabPage_Inventory.Size = new System.Drawing.Size(788, 391);
            this.TabPage_Inventory.TabIndex = 3;
            this.TabPage_Inventory.Text = "Inventory";
            // 
            // TabPage_Settings
            // 
            this.TabPage_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage_Settings.Controls.Add(this.nsTabControl1);
            this.TabPage_Settings.Location = new System.Drawing.Point(84, 4);
            this.TabPage_Settings.Name = "TabPage_Settings";
            this.TabPage_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Settings.Size = new System.Drawing.Size(788, 391);
            this.TabPage_Settings.TabIndex = 1;
            this.TabPage_Settings.Text = "Settings";
            // 
            // nsTabControl1
            // 
            this.nsTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.nsTabControl1.Controls.Add(this.Tab_Settings_Page_GeneralSettings);
            this.nsTabControl1.Controls.Add(this.Tab_Settings_Page_MovementSettings);
            this.nsTabControl1.Controls.Add(this.Tab_Settings_Page_CatchSettings);
            this.nsTabControl1.Controls.Add(this.Tab_Settings_Page_EvolveSettings);
            this.nsTabControl1.Controls.Add(this.Tab_Settings_Page_TransferSettings);
            this.nsTabControl1.Controls.Add(this.Tab_Settings_Page_InventorySettings);
            this.nsTabControl1.Controls.Add(this.Tab_Settings_Page_UseItemsSettings);
            this.nsTabControl1.Controls.Add(this.Tab_Settings_Page_SecuritySettings);
            this.nsTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.nsTabControl1.ItemSize = new System.Drawing.Size(28, 130);
            this.nsTabControl1.Location = new System.Drawing.Point(6, 6);
            this.nsTabControl1.Multiline = true;
            this.nsTabControl1.Name = "nsTabControl1";
            this.nsTabControl1.SelectedIndex = 0;
            this.nsTabControl1.Size = new System.Drawing.Size(776, 379);
            this.nsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nsTabControl1.TabIndex = 0;
            // 
            // Tab_Settings_Page_GeneralSettings
            // 
            this.Tab_Settings_Page_GeneralSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_CSVExpot);
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_Proxy);
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_Coordinates);
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_Login);
            this.Tab_Settings_Page_GeneralSettings.Location = new System.Drawing.Point(134, 4);
            this.Tab_Settings_Page_GeneralSettings.Name = "Tab_Settings_Page_GeneralSettings";
            this.Tab_Settings_Page_GeneralSettings.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Settings_Page_GeneralSettings.Size = new System.Drawing.Size(638, 371);
            this.Tab_Settings_Page_GeneralSettings.TabIndex = 0;
            this.Tab_Settings_Page_GeneralSettings.Text = "General Settings";
            // 
            // GroupBox_CSVExpot
            // 
            this.GroupBox_CSVExpot.Controls.Add(this.NumUpDown_CSVExportInMinutes);
            this.GroupBox_CSVExpot.Controls.Add(this.OnOff_UseCSVExport);
            this.GroupBox_CSVExpot.Controls.Add(this.nsLabel1);
            this.GroupBox_CSVExpot.DrawSeperator = false;
            this.GroupBox_CSVExpot.Location = new System.Drawing.Point(6, 296);
            this.GroupBox_CSVExpot.Name = "GroupBox_CSVExpot";
            this.GroupBox_CSVExpot.Size = new System.Drawing.Size(177, 69);
            this.GroupBox_CSVExpot.SubTitle = "Details";
            this.GroupBox_CSVExpot.TabIndex = 6;
            this.GroupBox_CSVExpot.Text = "GroupBox_CSVExpot";
            this.GroupBox_CSVExpot.Title = "CSV Expot";
            // 
            // NumUpDown_CSVExportInMinutes
            // 
            this.NumUpDown_CSVExportInMinutes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumUpDown_CSVExportInMinutes.ForeColor = System.Drawing.SystemColors.Window;
            this.NumUpDown_CSVExportInMinutes.Location = new System.Drawing.Point(129, 40);
            this.NumUpDown_CSVExportInMinutes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.NumUpDown_CSVExportInMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_CSVExportInMinutes.Name = "NumUpDown_CSVExportInMinutes";
            this.NumUpDown_CSVExportInMinutes.Size = new System.Drawing.Size(43, 20);
            this.NumUpDown_CSVExportInMinutes.TabIndex = 12;
            this.NumUpDown_CSVExportInMinutes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // OnOff_UseCSVExport
            // 
            this.OnOff_UseCSVExport.Checked = false;
            this.OnOff_UseCSVExport.Location = new System.Drawing.Point(118, 3);
            this.OnOff_UseCSVExport.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_UseCSVExport.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_UseCSVExport.Name = "OnOff_UseCSVExport";
            this.OnOff_UseCSVExport.Size = new System.Drawing.Size(56, 24);
            this.OnOff_UseCSVExport.TabIndex = 10;
            this.OnOff_UseCSVExport.Text = "OnOff_UseCSVExport";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(3, 43);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(153, 15);
            this.nsLabel1.TabIndex = 9;
            this.nsLabel1.Text = "nsLabel1";
            this.nsLabel1.Value1 = "Export every";
            this.nsLabel1.Value2 = "(minutes)";
            // 
            // GroupBox_Proxy
            // 
            this.GroupBox_Proxy.Controls.Add(this.NumUpDown_ProxyPort);
            this.GroupBox_Proxy.Controls.Add(this.Label_ProxyPassword);
            this.GroupBox_Proxy.Controls.Add(this.Label_ProxyUsername);
            this.GroupBox_Proxy.Controls.Add(this.Label_ProxyPort);
            this.GroupBox_Proxy.Controls.Add(this.Label_ProxyHost);
            this.GroupBox_Proxy.Controls.Add(this.TextBox_ProxyPassword);
            this.GroupBox_Proxy.Controls.Add(this.TextBox_ProxyUsername);
            this.GroupBox_Proxy.Controls.Add(this.TextBox_ProxyHost);
            this.GroupBox_Proxy.Controls.Add(this.OnOff_UseProxy);
            this.GroupBox_Proxy.DrawSeperator = false;
            this.GroupBox_Proxy.Location = new System.Drawing.Point(343, 6);
            this.GroupBox_Proxy.Name = "GroupBox_Proxy";
            this.GroupBox_Proxy.Size = new System.Drawing.Size(205, 156);
            this.GroupBox_Proxy.SubTitle = "Details";
            this.GroupBox_Proxy.TabIndex = 5;
            this.GroupBox_Proxy.Text = "GroupBox_Proxy";
            this.GroupBox_Proxy.Title = "Proxy";
            // 
            // NumUpDown_ProxyPort
            // 
            this.NumUpDown_ProxyPort.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumUpDown_ProxyPort.ForeColor = System.Drawing.SystemColors.Window;
            this.NumUpDown_ProxyPort.Location = new System.Drawing.Point(142, 71);
            this.NumUpDown_ProxyPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUpDown_ProxyPort.Name = "NumUpDown_ProxyPort";
            this.NumUpDown_ProxyPort.Size = new System.Drawing.Size(58, 20);
            this.NumUpDown_ProxyPort.TabIndex = 11;
            // 
            // Label_ProxyPassword
            // 
            this.Label_ProxyPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ProxyPassword.Location = new System.Drawing.Point(3, 131);
            this.Label_ProxyPassword.Name = "Label_ProxyPassword";
            this.Label_ProxyPassword.Size = new System.Drawing.Size(96, 15);
            this.Label_ProxyPassword.TabIndex = 8;
            this.Label_ProxyPassword.Text = "Label_ProxyPassword";
            this.Label_ProxyPassword.Value1 = "Proxy";
            this.Label_ProxyPassword.Value2 = "Password";
            // 
            // Label_ProxyUsername
            // 
            this.Label_ProxyUsername.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ProxyUsername.Location = new System.Drawing.Point(3, 102);
            this.Label_ProxyUsername.Name = "Label_ProxyUsername";
            this.Label_ProxyUsername.Size = new System.Drawing.Size(96, 15);
            this.Label_ProxyUsername.TabIndex = 7;
            this.Label_ProxyUsername.Text = "Label_ProxyUsername";
            this.Label_ProxyUsername.Value1 = "Proxy";
            this.Label_ProxyUsername.Value2 = "Username";
            // 
            // Label_ProxyPort
            // 
            this.Label_ProxyPort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ProxyPort.Location = new System.Drawing.Point(3, 73);
            this.Label_ProxyPort.Name = "Label_ProxyPort";
            this.Label_ProxyPort.Size = new System.Drawing.Size(96, 15);
            this.Label_ProxyPort.TabIndex = 6;
            this.Label_ProxyPort.Text = "Label_ProxyPort";
            this.Label_ProxyPort.Value1 = "Proxy";
            this.Label_ProxyPort.Value2 = "Port";
            // 
            // Label_ProxyHost
            // 
            this.Label_ProxyHost.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_ProxyHost.Location = new System.Drawing.Point(3, 44);
            this.Label_ProxyHost.Name = "Label_ProxyHost";
            this.Label_ProxyHost.Size = new System.Drawing.Size(96, 15);
            this.Label_ProxyHost.TabIndex = 5;
            this.Label_ProxyHost.Text = "Label_ProxyHost";
            this.Label_ProxyHost.Value1 = "Proxy";
            this.Label_ProxyHost.Value2 = "Host";
            // 
            // TextBox_ProxyPassword
            // 
            this.TextBox_ProxyPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_ProxyPassword.Location = new System.Drawing.Point(105, 127);
            this.TextBox_ProxyPassword.MaxLength = 25;
            this.TextBox_ProxyPassword.Multiline = false;
            this.TextBox_ProxyPassword.Name = "TextBox_ProxyPassword";
            this.TextBox_ProxyPassword.ReadOnly = false;
            this.TextBox_ProxyPassword.Size = new System.Drawing.Size(95, 23);
            this.TextBox_ProxyPassword.TabIndex = 4;
            this.TextBox_ProxyPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_ProxyPassword.UseSystemPasswordChar = false;
            // 
            // TextBox_ProxyUsername
            // 
            this.TextBox_ProxyUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_ProxyUsername.Location = new System.Drawing.Point(105, 98);
            this.TextBox_ProxyUsername.MaxLength = 25;
            this.TextBox_ProxyUsername.Multiline = false;
            this.TextBox_ProxyUsername.Name = "TextBox_ProxyUsername";
            this.TextBox_ProxyUsername.ReadOnly = false;
            this.TextBox_ProxyUsername.Size = new System.Drawing.Size(95, 23);
            this.TextBox_ProxyUsername.TabIndex = 3;
            this.TextBox_ProxyUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_ProxyUsername.UseSystemPasswordChar = false;
            // 
            // TextBox_ProxyHost
            // 
            this.TextBox_ProxyHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_ProxyHost.Location = new System.Drawing.Point(105, 40);
            this.TextBox_ProxyHost.MaxLength = 15;
            this.TextBox_ProxyHost.Multiline = false;
            this.TextBox_ProxyHost.Name = "TextBox_ProxyHost";
            this.TextBox_ProxyHost.ReadOnly = false;
            this.TextBox_ProxyHost.Size = new System.Drawing.Size(95, 23);
            this.TextBox_ProxyHost.TabIndex = 1;
            this.TextBox_ProxyHost.Text = "0.0.0.0";
            this.TextBox_ProxyHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_ProxyHost.UseSystemPasswordChar = false;
            // 
            // OnOff_UseProxy
            // 
            this.OnOff_UseProxy.Checked = false;
            this.OnOff_UseProxy.Location = new System.Drawing.Point(144, 3);
            this.OnOff_UseProxy.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_UseProxy.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_UseProxy.Name = "OnOff_UseProxy";
            this.OnOff_UseProxy.Size = new System.Drawing.Size(56, 24);
            this.OnOff_UseProxy.TabIndex = 0;
            this.OnOff_UseProxy.Text = "OnOff_UseProxy";
            // 
            // GroupBox_Coordinates
            // 
            this.GroupBox_Coordinates.Controls.Add(this.Label_DefaultAltitude);
            this.GroupBox_Coordinates.Controls.Add(this.Label_DefaultLongitude);
            this.GroupBox_Coordinates.Controls.Add(this.Label_DefaultLatitude);
            this.GroupBox_Coordinates.Controls.Add(this.TextBot_Altitude);
            this.GroupBox_Coordinates.Controls.Add(this.TextBot_Longitude);
            this.GroupBox_Coordinates.Controls.Add(this.TextBot_Latitude);
            this.GroupBox_Coordinates.DrawSeperator = false;
            this.GroupBox_Coordinates.Location = new System.Drawing.Point(152, 6);
            this.GroupBox_Coordinates.Name = "GroupBox_Coordinates";
            this.GroupBox_Coordinates.Size = new System.Drawing.Size(185, 126);
            this.GroupBox_Coordinates.SubTitle = "Default Values";
            this.GroupBox_Coordinates.TabIndex = 2;
            this.GroupBox_Coordinates.Text = "Coordinates";
            this.GroupBox_Coordinates.Title = "Coordinates";
            // 
            // Label_DefaultAltitude
            // 
            this.Label_DefaultAltitude.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_DefaultAltitude.Location = new System.Drawing.Point(3, 102);
            this.Label_DefaultAltitude.Name = "Label_DefaultAltitude";
            this.Label_DefaultAltitude.Size = new System.Drawing.Size(104, 15);
            this.Label_DefaultAltitude.TabIndex = 5;
            this.Label_DefaultAltitude.Text = "Label_DefaultAltitude";
            this.Label_DefaultAltitude.Value1 = "Default";
            this.Label_DefaultAltitude.Value2 = "Altitude";
            // 
            // Label_DefaultLongitude
            // 
            this.Label_DefaultLongitude.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_DefaultLongitude.Location = new System.Drawing.Point(3, 73);
            this.Label_DefaultLongitude.Name = "Label_DefaultLongitude";
            this.Label_DefaultLongitude.Size = new System.Drawing.Size(104, 15);
            this.Label_DefaultLongitude.TabIndex = 4;
            this.Label_DefaultLongitude.Text = "Label_DefaultLongitude";
            this.Label_DefaultLongitude.Value1 = "Default";
            this.Label_DefaultLongitude.Value2 = "Longitude";
            // 
            // Label_DefaultLatitude
            // 
            this.Label_DefaultLatitude.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_DefaultLatitude.Location = new System.Drawing.Point(3, 44);
            this.Label_DefaultLatitude.Name = "Label_DefaultLatitude";
            this.Label_DefaultLatitude.Size = new System.Drawing.Size(101, 15);
            this.Label_DefaultLatitude.TabIndex = 3;
            this.Label_DefaultLatitude.Text = "Label_DefaultLatitude";
            this.Label_DefaultLatitude.Value1 = "Default";
            this.Label_DefaultLatitude.Value2 = "Latitude";
            // 
            // TextBot_Altitude
            // 
            this.TextBot_Altitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBot_Altitude.Location = new System.Drawing.Point(125, 98);
            this.TextBot_Altitude.MaxLength = 32767;
            this.TextBot_Altitude.Multiline = false;
            this.TextBot_Altitude.Name = "TextBot_Altitude";
            this.TextBot_Altitude.ReadOnly = false;
            this.TextBot_Altitude.Size = new System.Drawing.Size(55, 23);
            this.TextBot_Altitude.TabIndex = 2;
            this.TextBot_Altitude.Text = "Altitude";
            this.TextBot_Altitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBot_Altitude.UseSystemPasswordChar = false;
            // 
            // TextBot_Longitude
            // 
            this.TextBot_Longitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBot_Longitude.Location = new System.Drawing.Point(110, 69);
            this.TextBot_Longitude.MaxLength = 32767;
            this.TextBot_Longitude.Multiline = false;
            this.TextBot_Longitude.Name = "TextBot_Longitude";
            this.TextBot_Longitude.ReadOnly = false;
            this.TextBot_Longitude.Size = new System.Drawing.Size(70, 23);
            this.TextBot_Longitude.TabIndex = 1;
            this.TextBot_Longitude.Text = "Longitude";
            this.TextBot_Longitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBot_Longitude.UseSystemPasswordChar = false;
            // 
            // TextBot_Latitude
            // 
            this.TextBot_Latitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBot_Latitude.Location = new System.Drawing.Point(110, 40);
            this.TextBot_Latitude.MaxLength = 32767;
            this.TextBot_Latitude.Multiline = false;
            this.TextBot_Latitude.Name = "TextBot_Latitude";
            this.TextBot_Latitude.ReadOnly = false;
            this.TextBot_Latitude.Size = new System.Drawing.Size(70, 23);
            this.TextBot_Latitude.TabIndex = 0;
            this.TextBot_Latitude.Text = "Latitude";
            this.TextBot_Latitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBot_Latitude.UseSystemPasswordChar = false;
            // 
            // GroupBox_Login
            // 
            this.GroupBox_Login.Controls.Add(this.TextBox_UserPassword);
            this.GroupBox_Login.Controls.Add(this.TextBox_UserNameOrEmail);
            this.GroupBox_Login.Controls.Add(this.ComboBox_AuthType);
            this.GroupBox_Login.DrawSeperator = false;
            this.GroupBox_Login.Location = new System.Drawing.Point(6, 6);
            this.GroupBox_Login.Name = "GroupBox_Login";
            this.GroupBox_Login.Size = new System.Drawing.Size(140, 99);
            this.GroupBox_Login.SubTitle = "Details";
            this.GroupBox_Login.TabIndex = 1;
            this.GroupBox_Login.Text = "GroupBox_Login";
            this.GroupBox_Login.Title = "Login";
            this.GroupBox_Login.Click += new System.EventHandler(this.nsGroupBox1_Click);
            // 
            // TextBox_UserPassword
            // 
            this.TextBox_UserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_UserPassword.Location = new System.Drawing.Point(3, 69);
            this.TextBox_UserPassword.MaxLength = 32767;
            this.TextBox_UserPassword.Multiline = false;
            this.TextBox_UserPassword.Name = "TextBox_UserPassword";
            this.TextBox_UserPassword.ReadOnly = false;
            this.TextBox_UserPassword.Size = new System.Drawing.Size(134, 23);
            this.TextBox_UserPassword.TabIndex = 2;
            this.TextBox_UserPassword.Text = "User Password";
            this.TextBox_UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_UserPassword.UseSystemPasswordChar = false;
            this.TextBox_UserPassword.TextChanged += new System.EventHandler(this.nsTextBox2_TextChanged);
            // 
            // TextBox_UserNameOrEmail
            // 
            this.TextBox_UserNameOrEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_UserNameOrEmail.Location = new System.Drawing.Point(3, 40);
            this.TextBox_UserNameOrEmail.MaxLength = 32767;
            this.TextBox_UserNameOrEmail.Multiline = false;
            this.TextBox_UserNameOrEmail.Name = "TextBox_UserNameOrEmail";
            this.TextBox_UserNameOrEmail.ReadOnly = false;
            this.TextBox_UserNameOrEmail.Size = new System.Drawing.Size(134, 23);
            this.TextBox_UserNameOrEmail.TabIndex = 1;
            this.TextBox_UserNameOrEmail.Text = "UserName or Email";
            this.TextBox_UserNameOrEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_UserNameOrEmail.UseSystemPasswordChar = false;
            this.TextBox_UserNameOrEmail.TextChanged += new System.EventHandler(this.nsTextBox1_TextChanged);
            // 
            // ComboBox_AuthType
            // 
            this.ComboBox_AuthType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_AuthType.AutoCompleteCustomSource.AddRange(new string[] {
            "PTC",
            "Google"});
            this.ComboBox_AuthType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBox_AuthType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_AuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_AuthType.ForeColor = System.Drawing.Color.White;
            this.ComboBox_AuthType.FormattingEnabled = true;
            this.ComboBox_AuthType.Items.AddRange(new object[] {
            "Ptc",
            "Google"});
            this.ComboBox_AuthType.Location = new System.Drawing.Point(59, 3);
            this.ComboBox_AuthType.Name = "ComboBox_AuthType";
            this.ComboBox_AuthType.Size = new System.Drawing.Size(74, 21);
            this.ComboBox_AuthType.TabIndex = 0;
            this.ComboBox_AuthType.SelectedIndexChanged += new System.EventHandler(this.nsComboBox1_SelectedIndexChanged);
            // 
            // Tab_Settings_Page_MovementSettings
            // 
            this.Tab_Settings_Page_MovementSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Settings_Page_MovementSettings.Controls.Add(this.GroupBox_GPXPathing);
            this.Tab_Settings_Page_MovementSettings.Controls.Add(this.nsGroupBox1);
            this.Tab_Settings_Page_MovementSettings.Location = new System.Drawing.Point(134, 4);
            this.Tab_Settings_Page_MovementSettings.Name = "Tab_Settings_Page_MovementSettings";
            this.Tab_Settings_Page_MovementSettings.Size = new System.Drawing.Size(638, 371);
            this.Tab_Settings_Page_MovementSettings.TabIndex = 2;
            this.Tab_Settings_Page_MovementSettings.Text = "Movement Settings";
            // 
            // GroupBox_GPXPathing
            // 
            this.GroupBox_GPXPathing.Controls.Add(this.OnOff_GPXIgnorePokestops);
            this.GroupBox_GPXPathing.Controls.Add(this.TextBot_GPXFile);
            this.GroupBox_GPXPathing.Controls.Add(this.Button_SelectGPXFile);
            this.GroupBox_GPXPathing.Controls.Add(this.Label_GPXIgnorePokestops);
            this.GroupBox_GPXPathing.Controls.Add(this.Label_GPXFile);
            this.GroupBox_GPXPathing.DrawSeperator = false;
            this.GroupBox_GPXPathing.Location = new System.Drawing.Point(6, 110);
            this.GroupBox_GPXPathing.Name = "GroupBox_GPXPathing";
            this.GroupBox_GPXPathing.Size = new System.Drawing.Size(208, 93);
            this.GroupBox_GPXPathing.SubTitle = "Details";
            this.GroupBox_GPXPathing.TabIndex = 5;
            this.GroupBox_GPXPathing.Text = "GPXPathing";
            this.GroupBox_GPXPathing.Title = "GPXPathing";
            // 
            // OnOff_GPXIgnorePokestops
            // 
            this.OnOff_GPXIgnorePokestops.Checked = false;
            this.OnOff_GPXIgnorePokestops.Location = new System.Drawing.Point(149, 66);
            this.OnOff_GPXIgnorePokestops.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_GPXIgnorePokestops.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_GPXIgnorePokestops.Name = "OnOff_GPXIgnorePokestops";
            this.OnOff_GPXIgnorePokestops.Size = new System.Drawing.Size(56, 24);
            this.OnOff_GPXIgnorePokestops.TabIndex = 8;
            this.OnOff_GPXIgnorePokestops.Text = "OnOff_GPXIgnorePokestops";
            // 
            // TextBot_GPXFile
            // 
            this.TextBot_GPXFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBot_GPXFile.Location = new System.Drawing.Point(56, 40);
            this.TextBot_GPXFile.MaxLength = 32767;
            this.TextBot_GPXFile.Multiline = false;
            this.TextBot_GPXFile.Name = "TextBot_GPXFile";
            this.TextBot_GPXFile.ReadOnly = false;
            this.TextBot_GPXFile.Size = new System.Drawing.Size(92, 23);
            this.TextBot_GPXFile.TabIndex = 7;
            this.TextBot_GPXFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBot_GPXFile.UseSystemPasswordChar = false;
            // 
            // Button_SelectGPXFile
            // 
            this.Button_SelectGPXFile.Location = new System.Drawing.Point(154, 40);
            this.Button_SelectGPXFile.Name = "Button_SelectGPXFile";
            this.Button_SelectGPXFile.Size = new System.Drawing.Size(49, 23);
            this.Button_SelectGPXFile.TabIndex = 6;
            this.Button_SelectGPXFile.Text = "Select";
            this.Button_SelectGPXFile.Click += new System.EventHandler(this.Button_SelectGPXFile_Click);
            // 
            // Label_GPXIgnorePokestops
            // 
            this.Label_GPXIgnorePokestops.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_GPXIgnorePokestops.Location = new System.Drawing.Point(3, 69);
            this.Label_GPXIgnorePokestops.Name = "Label_GPXIgnorePokestops";
            this.Label_GPXIgnorePokestops.Size = new System.Drawing.Size(130, 21);
            this.Label_GPXIgnorePokestops.TabIndex = 5;
            this.Label_GPXIgnorePokestops.Text = "Label_GPXIgnorePokestops";
            this.Label_GPXIgnorePokestops.Value1 = "GPX";
            this.Label_GPXIgnorePokestops.Value2 = "Ignore Pokestops";
            // 
            // Label_GPXFile
            // 
            this.Label_GPXFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_GPXFile.Location = new System.Drawing.Point(3, 40);
            this.Label_GPXFile.Name = "Label_GPXFile";
            this.Label_GPXFile.Size = new System.Drawing.Size(115, 21);
            this.Label_GPXFile.TabIndex = 4;
            this.Label_GPXFile.Text = "Label_GPXFile";
            this.Label_GPXFile.Value1 = "GPX";
            this.Label_GPXFile.Value2 = "File";
            // 
            // nsGroupBox1
            // 
            this.nsGroupBox1.Controls.Add(this.NumUpDown_WalkingSpeed);
            this.nsGroupBox1.Controls.Add(this.NumUpDown_MaxTravelDistance);
            this.nsGroupBox1.Controls.Add(this.Label_MaxTravelDistance);
            this.nsGroupBox1.Controls.Add(this.Label_WalkingSpeed);
            this.nsGroupBox1.Controls.Add(this.ComboBox_MovementType);
            this.nsGroupBox1.DrawSeperator = false;
            this.nsGroupBox1.Location = new System.Drawing.Point(6, 6);
            this.nsGroupBox1.Name = "nsGroupBox1";
            this.nsGroupBox1.Size = new System.Drawing.Size(230, 98);
            this.nsGroupBox1.SubTitle = "Details";
            this.nsGroupBox1.TabIndex = 4;
            this.nsGroupBox1.Text = "Movement";
            this.nsGroupBox1.Title = "Movement";
            // 
            // NumUpDown_WalkingSpeed
            // 
            this.NumUpDown_WalkingSpeed.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumUpDown_WalkingSpeed.DecimalPlaces = 2;
            this.NumUpDown_WalkingSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.NumUpDown_WalkingSpeed.Location = new System.Drawing.Point(169, 40);
            this.NumUpDown_WalkingSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumUpDown_WalkingSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_WalkingSpeed.Name = "NumUpDown_WalkingSpeed";
            this.NumUpDown_WalkingSpeed.Size = new System.Drawing.Size(58, 20);
            this.NumUpDown_WalkingSpeed.TabIndex = 10;
            this.NumUpDown_WalkingSpeed.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // NumUpDown_MaxTravelDistance
            // 
            this.NumUpDown_MaxTravelDistance.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumUpDown_MaxTravelDistance.ForeColor = System.Drawing.SystemColors.Window;
            this.NumUpDown_MaxTravelDistance.Location = new System.Drawing.Point(169, 73);
            this.NumUpDown_MaxTravelDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUpDown_MaxTravelDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_MaxTravelDistance.Name = "NumUpDown_MaxTravelDistance";
            this.NumUpDown_MaxTravelDistance.Size = new System.Drawing.Size(58, 20);
            this.NumUpDown_MaxTravelDistance.TabIndex = 9;
            this.NumUpDown_MaxTravelDistance.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Label_MaxTravelDistance
            // 
            this.Label_MaxTravelDistance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_MaxTravelDistance.Location = new System.Drawing.Point(3, 73);
            this.Label_MaxTravelDistance.Name = "Label_MaxTravelDistance";
            this.Label_MaxTravelDistance.Size = new System.Drawing.Size(178, 21);
            this.Label_MaxTravelDistance.TabIndex = 2;
            this.Label_MaxTravelDistance.Text = "Label_MaxTravelDistance";
            this.Label_MaxTravelDistance.Value1 = "Max.";
            this.Label_MaxTravelDistance.Value2 = "Travel Distance (meters)";
            // 
            // Label_WalkingSpeed
            // 
            this.Label_WalkingSpeed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_WalkingSpeed.Location = new System.Drawing.Point(3, 43);
            this.Label_WalkingSpeed.Name = "Label_WalkingSpeed";
            this.Label_WalkingSpeed.Size = new System.Drawing.Size(130, 15);
            this.Label_WalkingSpeed.TabIndex = 1;
            this.Label_WalkingSpeed.Text = "Label_WalkingSpeed";
            this.Label_WalkingSpeed.Value1 = "Walking";
            this.Label_WalkingSpeed.Value2 = "Speed (km/h)";
            // 
            // ComboBox_MovementType
            // 
            this.ComboBox_MovementType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBox_MovementType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_MovementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_MovementType.ForeColor = System.Drawing.Color.White;
            this.ComboBox_MovementType.FormattingEnabled = true;
            this.ComboBox_MovementType.Items.AddRange(new object[] {
            "Default",
            "GPX Pathing",
            "Teleport"});
            this.ComboBox_MovementType.Location = new System.Drawing.Point(114, 3);
            this.ComboBox_MovementType.Name = "ComboBox_MovementType";
            this.ComboBox_MovementType.Size = new System.Drawing.Size(111, 21);
            this.ComboBox_MovementType.TabIndex = 0;
            // 
            // Tab_Settings_Page_CatchSettings
            // 
            this.Tab_Settings_Page_CatchSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Settings_Page_CatchSettings.Controls.Add(this.nsGroupBox5);
            this.Tab_Settings_Page_CatchSettings.Controls.Add(this.nsGroupBox4);
            this.Tab_Settings_Page_CatchSettings.Controls.Add(this.GroupBox_ToNotCatchList);
            this.Tab_Settings_Page_CatchSettings.Controls.Add(this.GroupBox_CatchPokemon);
            this.Tab_Settings_Page_CatchSettings.Location = new System.Drawing.Point(134, 4);
            this.Tab_Settings_Page_CatchSettings.Name = "Tab_Settings_Page_CatchSettings";
            this.Tab_Settings_Page_CatchSettings.Size = new System.Drawing.Size(638, 371);
            this.Tab_Settings_Page_CatchSettings.TabIndex = 5;
            this.Tab_Settings_Page_CatchSettings.Text = "Catch Settings";
            // 
            // nsGroupBox5
            // 
            this.nsGroupBox5.DrawSeperator = false;
            this.nsGroupBox5.Location = new System.Drawing.Point(6, 140);
            this.nsGroupBox5.Name = "nsGroupBox5";
            this.nsGroupBox5.Size = new System.Drawing.Size(200, 195);
            this.nsGroupBox5.SubTitle = "Details";
            this.nsGroupBox5.TabIndex = 4;
            this.nsGroupBox5.Text = "nsGroupBox5";
            this.nsGroupBox5.Title = "Pokeball";
            // 
            // nsGroupBox4
            // 
            this.nsGroupBox4.DrawSeperator = false;
            this.nsGroupBox4.Location = new System.Drawing.Point(212, 6);
            this.nsGroupBox4.Name = "nsGroupBox4";
            this.nsGroupBox4.Size = new System.Drawing.Size(192, 128);
            this.nsGroupBox4.SubTitle = "Details";
            this.nsGroupBox4.TabIndex = 3;
            this.nsGroupBox4.Text = "nsGroupBox4";
            this.nsGroupBox4.Title = "Use Berries";
            // 
            // GroupBox_ToNotCatchList
            // 
            this.GroupBox_ToNotCatchList.Controls.Add(this.Button_CatchListUnselectAll);
            this.GroupBox_ToNotCatchList.Controls.Add(this.Button_CatchListSelectAll);
            this.GroupBox_ToNotCatchList.Controls.Add(this.OnOff_ToNotCatchList);
            this.GroupBox_ToNotCatchList.Controls.Add(this.checkedList_ToNotCatchList);
            this.GroupBox_ToNotCatchList.DrawSeperator = false;
            this.GroupBox_ToNotCatchList.Location = new System.Drawing.Point(443, 6);
            this.GroupBox_ToNotCatchList.Name = "GroupBox_ToNotCatchList";
            this.GroupBox_ToNotCatchList.Size = new System.Drawing.Size(192, 359);
            this.GroupBox_ToNotCatchList.SubTitle = "Details";
            this.GroupBox_ToNotCatchList.TabIndex = 2;
            this.GroupBox_ToNotCatchList.Text = "GroupBox_ToNotCatchList";
            this.GroupBox_ToNotCatchList.Title = "Not Catch List";
            // 
            // Button_CatchListUnselectAll
            // 
            this.Button_CatchListUnselectAll.Location = new System.Drawing.Point(105, 333);
            this.Button_CatchListUnselectAll.Name = "Button_CatchListUnselectAll";
            this.Button_CatchListUnselectAll.Size = new System.Drawing.Size(81, 23);
            this.Button_CatchListUnselectAll.TabIndex = 8;
            this.Button_CatchListUnselectAll.Text = "Unselect All";
            this.Button_CatchListUnselectAll.Click += new System.EventHandler(this.Button_CatchListUnselectAll_Click);
            // 
            // Button_CatchListSelectAll
            // 
            this.Button_CatchListSelectAll.Location = new System.Drawing.Point(6, 333);
            this.Button_CatchListSelectAll.Name = "Button_CatchListSelectAll";
            this.Button_CatchListSelectAll.Size = new System.Drawing.Size(66, 23);
            this.Button_CatchListSelectAll.TabIndex = 7;
            this.Button_CatchListSelectAll.Text = "Select All";
            this.Button_CatchListSelectAll.Click += new System.EventHandler(this.Button_CatchListSelectAll_Click);
            // 
            // OnOff_ToNotCatchList
            // 
            this.OnOff_ToNotCatchList.Checked = false;
            this.OnOff_ToNotCatchList.Location = new System.Drawing.Point(133, 3);
            this.OnOff_ToNotCatchList.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_ToNotCatchList.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_ToNotCatchList.Name = "OnOff_ToNotCatchList";
            this.OnOff_ToNotCatchList.Size = new System.Drawing.Size(56, 24);
            this.OnOff_ToNotCatchList.TabIndex = 2;
            this.OnOff_ToNotCatchList.Text = "OnOff_ToNotCatchList";
            // 
            // checkedList_ToNotCatchList
            // 
            this.checkedList_ToNotCatchList.FormattingEnabled = true;
            this.checkedList_ToNotCatchList.Items.AddRange(new object[] {
            "Bulbasaur",
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie",
            "Metapod",
            "Butterfree",
            "Weedle",
            "Kakuna",
            "Beedrill",
            "Pidgey",
            "Pidgeotto",
            "Pidgeot",
            "Rattata",
            "Raticate",
            "Spearow",
            "Fearow",
            "Ekans",
            "Arbok",
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash",
            "NidoranFemale",
            "Nidorina",
            "Nidoqueen",
            "NidoranMale",
            "Nidorino",
            "Nidoking",
            "Clefairy",
            "Clefable",
            "Vulpix",
            "Ninetales",
            "Jigglypuff",
            "Wigglytuff",
            "Zubat",
            "Golbat",
            "Oddish",
            "Gloom",
            "Vileplume",
            "Paras",
            "Parasect",
            "Venonat",
            "Venomoth",
            "Diglett",
            "Dugtrio",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Abra",
            "Kadabra",
            "Alakazam",
            "Machop",
            "Machoke",
            "Machamp",
            "Bellsprout",
            "Weepinbell",
            "Victreebel",
            "Tentacool",
            "Tentacruel",
            "Geodude",
            "Graveler",
            "Golem",
            "Ponyta",
            "Rapidash",
            "Slowpoke",
            "Slowbro",
            "Magnemite",
            "Magneton",
            "Farfetchd",
            "Doduo",
            "Dodrio",
            "Seel",
            "Dewgong",
            "Grimer",
            "Muk",
            "Shellder",
            "Cloyster",
            "Gastly",
            "Haunter",
            "Gengar",
            "Onix",
            "Drowzee",
            "Hypno",
            "Krabby",
            "Kingler",
            "Voltorb",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Cubone",
            "Marowak",
            "Hitmonlee",
            "Hitmonchan",
            "Lickitung",
            "Koffing",
            "Weezing",
            "Rhyhorn",
            "Rhydon",
            "Chansey",
            "Tangela",
            "Kangaskhan",
            "Horsea",
            "Seadra",
            "Goldeen",
            "Seaking",
            "Staryu",
            "Starmie",
            "MrMime",
            "Scyther",
            "Jynx",
            "Electabuzz",
            "Magmar",
            "Pinsir",
            "Tauros",
            "Magikarp",
            "Gyarados",
            "Lapras",
            "Ditto",
            "Eevee",
            "Vaporeon",
            "Jolteon",
            "Flareon",
            "Porygon",
            "Omanyte",
            "Omastar",
            "Kabuto",
            "Kabutops",
            "Aerodactyl",
            "Snorlax",
            "Articuno",
            "Zapdos",
            "Moltres",
            "Dratini",
            "Dragonair",
            "Dragonite",
            "Mewtwo",
            "Mew"});
            this.checkedList_ToNotCatchList.Location = new System.Drawing.Point(6, 40);
            this.checkedList_ToNotCatchList.Name = "checkedList_ToNotCatchList";
            this.checkedList_ToNotCatchList.Size = new System.Drawing.Size(180, 289);
            this.checkedList_ToNotCatchList.TabIndex = 1;
            this.checkedList_ToNotCatchList.SelectedIndexChanged += new System.EventHandler(this.checkedList_ToNotCatchList_SelectedIndexChanged);
            // 
            // GroupBox_CatchPokemon
            // 
            this.GroupBox_CatchPokemon.Controls.Add(this.Label_CatchLuredPokemon);
            this.GroupBox_CatchPokemon.Controls.Add(this.Label_CatchIncensePokemon);
            this.GroupBox_CatchPokemon.Controls.Add(this.Label_CatchMapPokemon);
            this.GroupBox_CatchPokemon.Controls.Add(this.OnOff_CatchLuredPokemon);
            this.GroupBox_CatchPokemon.Controls.Add(this.OnOff_CatchIncensePokemon);
            this.GroupBox_CatchPokemon.Controls.Add(this.OnOff_CatchMapPokemon);
            this.GroupBox_CatchPokemon.DrawSeperator = false;
            this.GroupBox_CatchPokemon.Location = new System.Drawing.Point(6, 6);
            this.GroupBox_CatchPokemon.Name = "GroupBox_CatchPokemon";
            this.GroupBox_CatchPokemon.Size = new System.Drawing.Size(200, 128);
            this.GroupBox_CatchPokemon.SubTitle = "Details";
            this.GroupBox_CatchPokemon.TabIndex = 0;
            this.GroupBox_CatchPokemon.Text = "GroupBox_CatchPokemon";
            this.GroupBox_CatchPokemon.Title = "Catch Pokemon";
            // 
            // Label_CatchLuredPokemon
            // 
            this.Label_CatchLuredPokemon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_CatchLuredPokemon.Location = new System.Drawing.Point(3, 102);
            this.Label_CatchLuredPokemon.Name = "Label_CatchLuredPokemon";
            this.Label_CatchLuredPokemon.Size = new System.Drawing.Size(130, 15);
            this.Label_CatchLuredPokemon.TabIndex = 5;
            this.Label_CatchLuredPokemon.Text = "Label_CatchLuredPokemon";
            this.Label_CatchLuredPokemon.Value1 = "Catch";
            this.Label_CatchLuredPokemon.Value2 = "LuredPokemon";
            // 
            // Label_CatchIncensePokemon
            // 
            this.Label_CatchIncensePokemon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_CatchIncensePokemon.Location = new System.Drawing.Point(3, 73);
            this.Label_CatchIncensePokemon.Name = "Label_CatchIncensePokemon";
            this.Label_CatchIncensePokemon.Size = new System.Drawing.Size(130, 15);
            this.Label_CatchIncensePokemon.TabIndex = 4;
            this.Label_CatchIncensePokemon.Text = "Label_CatchIncensePokemon";
            this.Label_CatchIncensePokemon.Value1 = "Catch";
            this.Label_CatchIncensePokemon.Value2 = "IncensePokemon";
            // 
            // Label_CatchMapPokemon
            // 
            this.Label_CatchMapPokemon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_CatchMapPokemon.Location = new System.Drawing.Point(3, 43);
            this.Label_CatchMapPokemon.Name = "Label_CatchMapPokemon";
            this.Label_CatchMapPokemon.Size = new System.Drawing.Size(130, 15);
            this.Label_CatchMapPokemon.TabIndex = 3;
            this.Label_CatchMapPokemon.Text = "Label_CatchMapPokemon";
            this.Label_CatchMapPokemon.Value1 = "Catch";
            this.Label_CatchMapPokemon.Value2 = "NormalPokemon";
            // 
            // OnOff_CatchLuredPokemon
            // 
            this.OnOff_CatchLuredPokemon.Checked = false;
            this.OnOff_CatchLuredPokemon.Location = new System.Drawing.Point(139, 98);
            this.OnOff_CatchLuredPokemon.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_CatchLuredPokemon.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_CatchLuredPokemon.Name = "OnOff_CatchLuredPokemon";
            this.OnOff_CatchLuredPokemon.Size = new System.Drawing.Size(56, 24);
            this.OnOff_CatchLuredPokemon.TabIndex = 2;
            this.OnOff_CatchLuredPokemon.Text = "OnOff_CatchLuredPokemon";
            // 
            // OnOff_CatchIncensePokemon
            // 
            this.OnOff_CatchIncensePokemon.Checked = false;
            this.OnOff_CatchIncensePokemon.Location = new System.Drawing.Point(139, 69);
            this.OnOff_CatchIncensePokemon.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_CatchIncensePokemon.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_CatchIncensePokemon.Name = "OnOff_CatchIncensePokemon";
            this.OnOff_CatchIncensePokemon.Size = new System.Drawing.Size(56, 24);
            this.OnOff_CatchIncensePokemon.TabIndex = 1;
            this.OnOff_CatchIncensePokemon.Text = "OnOff_CatchIncensePokemon";
            // 
            // OnOff_CatchMapPokemon
            // 
            this.OnOff_CatchMapPokemon.Checked = false;
            this.OnOff_CatchMapPokemon.Location = new System.Drawing.Point(139, 40);
            this.OnOff_CatchMapPokemon.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_CatchMapPokemon.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_CatchMapPokemon.Name = "OnOff_CatchMapPokemon";
            this.OnOff_CatchMapPokemon.Size = new System.Drawing.Size(56, 24);
            this.OnOff_CatchMapPokemon.TabIndex = 0;
            this.OnOff_CatchMapPokemon.Text = "OnOff_CatchMapPokemon";
            // 
            // Tab_Settings_Page_EvolveSettings
            // 
            this.Tab_Settings_Page_EvolveSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Settings_Page_EvolveSettings.Controls.Add(this.GroupBox_EvolvePokemon);
            this.Tab_Settings_Page_EvolveSettings.Controls.Add(this.GroupBox_ToEvolveList);
            this.Tab_Settings_Page_EvolveSettings.Location = new System.Drawing.Point(134, 4);
            this.Tab_Settings_Page_EvolveSettings.Name = "Tab_Settings_Page_EvolveSettings";
            this.Tab_Settings_Page_EvolveSettings.Size = new System.Drawing.Size(638, 371);
            this.Tab_Settings_Page_EvolveSettings.TabIndex = 3;
            this.Tab_Settings_Page_EvolveSettings.Text = "Evolve Settings";
            // 
            // GroupBox_EvolvePokemon
            // 
            this.GroupBox_EvolvePokemon.Controls.Add(this.numericUpDown3);
            this.GroupBox_EvolvePokemon.Controls.Add(this.nsLabel2);
            this.GroupBox_EvolvePokemon.Controls.Add(this.numericUpDown2);
            this.GroupBox_EvolvePokemon.Controls.Add(this.numericUpDown1);
            this.GroupBox_EvolvePokemon.Controls.Add(this.nsLabel24);
            this.GroupBox_EvolvePokemon.Controls.Add(this.nsLabel23);
            this.GroupBox_EvolvePokemon.Controls.Add(this.OnOff_EvolvePokemon);
            this.GroupBox_EvolvePokemon.DrawSeperator = false;
            this.GroupBox_EvolvePokemon.Location = new System.Drawing.Point(6, 6);
            this.GroupBox_EvolvePokemon.Name = "GroupBox_EvolvePokemon";
            this.GroupBox_EvolvePokemon.Size = new System.Drawing.Size(334, 256);
            this.GroupBox_EvolvePokemon.SubTitle = "Details";
            this.GroupBox_EvolvePokemon.TabIndex = 4;
            this.GroupBox_EvolvePokemon.Text = "GroupBox_EvolvePokemon";
            this.GroupBox_EvolvePokemon.Title = "Evolve Pokemon";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numericUpDown3.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown3.Location = new System.Drawing.Point(103, 141);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown3.TabIndex = 14;
            this.numericUpDown3.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // nsLabel2
            // 
            this.nsLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel2.Location = new System.Drawing.Point(3, 146);
            this.nsLabel2.Name = "nsLabel2";
            this.nsLabel2.Size = new System.Drawing.Size(158, 15);
            this.nsLabel2.TabIndex = 13;
            this.nsLabel2.Text = "nsLabel2";
            this.nsLabel2.Value1 = "Keep";
            this.nsLabel2.Value2 = "Candies";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numericUpDown2.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown2.Location = new System.Drawing.Point(103, 69);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Location = new System.Drawing.Point(103, 40);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // nsLabel24
            // 
            this.nsLabel24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel24.Location = new System.Drawing.Point(3, 73);
            this.nsLabel24.Name = "nsLabel24";
            this.nsLabel24.Size = new System.Drawing.Size(130, 15);
            this.nsLabel24.TabIndex = 6;
            this.nsLabel24.Text = "nsLabel24";
            this.nsLabel24.Value1 = "Evolve";
            this.nsLabel24.Value2 = "AboveCP";
            // 
            // nsLabel23
            // 
            this.nsLabel23.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel23.Location = new System.Drawing.Point(3, 43);
            this.nsLabel23.Name = "nsLabel23";
            this.nsLabel23.Size = new System.Drawing.Size(130, 15);
            this.nsLabel23.TabIndex = 5;
            this.nsLabel23.Text = "nsLabel23";
            this.nsLabel23.Value1 = "Evolve";
            this.nsLabel23.Value2 = "AboveIV";
            // 
            // OnOff_EvolvePokemon
            // 
            this.OnOff_EvolvePokemon.Checked = false;
            this.OnOff_EvolvePokemon.Location = new System.Drawing.Point(275, 3);
            this.OnOff_EvolvePokemon.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_EvolvePokemon.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_EvolvePokemon.Name = "OnOff_EvolvePokemon";
            this.OnOff_EvolvePokemon.Size = new System.Drawing.Size(56, 24);
            this.OnOff_EvolvePokemon.TabIndex = 0;
            this.OnOff_EvolvePokemon.Text = "OnOff_EvolvePokemon";
            // 
            // GroupBox_ToEvolveList
            // 
            this.GroupBox_ToEvolveList.Controls.Add(this.Button_EvolveListUnselectAll);
            this.GroupBox_ToEvolveList.Controls.Add(this.Button_EvolveListSelectAll);
            this.GroupBox_ToEvolveList.Controls.Add(this.OnOff_ToEvolveList);
            this.GroupBox_ToEvolveList.Controls.Add(this.checkedList_ToEvolveList);
            this.GroupBox_ToEvolveList.DrawSeperator = false;
            this.GroupBox_ToEvolveList.Location = new System.Drawing.Point(443, 6);
            this.GroupBox_ToEvolveList.Name = "GroupBox_ToEvolveList";
            this.GroupBox_ToEvolveList.Size = new System.Drawing.Size(192, 359);
            this.GroupBox_ToEvolveList.SubTitle = "Details";
            this.GroupBox_ToEvolveList.TabIndex = 3;
            this.GroupBox_ToEvolveList.Text = "GroupBox_ToEvolveList";
            this.GroupBox_ToEvolveList.Title = "Evolve Only List";
            // 
            // Button_EvolveListUnselectAll
            // 
            this.Button_EvolveListUnselectAll.Location = new System.Drawing.Point(105, 333);
            this.Button_EvolveListUnselectAll.Name = "Button_EvolveListUnselectAll";
            this.Button_EvolveListUnselectAll.Size = new System.Drawing.Size(81, 23);
            this.Button_EvolveListUnselectAll.TabIndex = 4;
            this.Button_EvolveListUnselectAll.Text = "Unselect All";
            this.Button_EvolveListUnselectAll.Click += new System.EventHandler(this.Button_EvolveListUnselectAll_Click);
            // 
            // Button_EvolveListSelectAll
            // 
            this.Button_EvolveListSelectAll.Location = new System.Drawing.Point(6, 333);
            this.Button_EvolveListSelectAll.Name = "Button_EvolveListSelectAll";
            this.Button_EvolveListSelectAll.Size = new System.Drawing.Size(66, 23);
            this.Button_EvolveListSelectAll.TabIndex = 3;
            this.Button_EvolveListSelectAll.Text = "Select All";
            this.Button_EvolveListSelectAll.Click += new System.EventHandler(this.Button_EvolveListSelectAll_Click);
            // 
            // OnOff_ToEvolveList
            // 
            this.OnOff_ToEvolveList.Checked = false;
            this.OnOff_ToEvolveList.Location = new System.Drawing.Point(133, 3);
            this.OnOff_ToEvolveList.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_ToEvolveList.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_ToEvolveList.Name = "OnOff_ToEvolveList";
            this.OnOff_ToEvolveList.Size = new System.Drawing.Size(56, 24);
            this.OnOff_ToEvolveList.TabIndex = 2;
            this.OnOff_ToEvolveList.Text = "OnOff_ToEvolveList";
            // 
            // checkedList_ToEvolveList
            // 
            this.checkedList_ToEvolveList.FormattingEnabled = true;
            this.checkedList_ToEvolveList.Items.AddRange(new object[] {
            "Bulbasaur",
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie",
            "Metapod",
            "Butterfree",
            "Weedle",
            "Kakuna",
            "Beedrill",
            "Pidgey",
            "Pidgeotto",
            "Pidgeot",
            "Rattata",
            "Raticate",
            "Spearow",
            "Fearow",
            "Ekans",
            "Arbok",
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash",
            "NidoranFemale",
            "Nidorina",
            "Nidoqueen",
            "NidoranMale",
            "Nidorino",
            "Nidoking",
            "Clefairy",
            "Clefable",
            "Vulpix",
            "Ninetales",
            "Jigglypuff",
            "Wigglytuff",
            "Zubat",
            "Golbat",
            "Oddish",
            "Gloom",
            "Vileplume",
            "Paras",
            "Parasect",
            "Venonat",
            "Venomoth",
            "Diglett",
            "Dugtrio",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Abra",
            "Kadabra",
            "Alakazam",
            "Machop",
            "Machoke",
            "Machamp",
            "Bellsprout",
            "Weepinbell",
            "Victreebel",
            "Tentacool",
            "Tentacruel",
            "Geodude",
            "Graveler",
            "Golem",
            "Ponyta",
            "Rapidash",
            "Slowpoke",
            "Slowbro",
            "Magnemite",
            "Magneton",
            "Farfetchd",
            "Doduo",
            "Dodrio",
            "Seel",
            "Dewgong",
            "Grimer",
            "Muk",
            "Shellder",
            "Cloyster",
            "Gastly",
            "Haunter",
            "Gengar",
            "Onix",
            "Drowzee",
            "Hypno",
            "Krabby",
            "Kingler",
            "Voltorb",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Cubone",
            "Marowak",
            "Hitmonlee",
            "Hitmonchan",
            "Lickitung",
            "Koffing",
            "Weezing",
            "Rhyhorn",
            "Rhydon",
            "Chansey",
            "Tangela",
            "Kangaskhan",
            "Horsea",
            "Seadra",
            "Goldeen",
            "Seaking",
            "Staryu",
            "Starmie",
            "MrMime",
            "Scyther",
            "Jynx",
            "Electabuzz",
            "Magmar",
            "Pinsir",
            "Tauros",
            "Magikarp",
            "Gyarados",
            "Lapras",
            "Ditto",
            "Eevee",
            "Vaporeon",
            "Jolteon",
            "Flareon",
            "Porygon",
            "Omanyte",
            "Omastar",
            "Kabuto",
            "Kabutops",
            "Aerodactyl",
            "Snorlax",
            "Articuno",
            "Zapdos",
            "Moltres",
            "Dratini",
            "Dragonair",
            "Dragonite",
            "Mewtwo",
            "Mew"});
            this.checkedList_ToEvolveList.Location = new System.Drawing.Point(6, 40);
            this.checkedList_ToEvolveList.Name = "checkedList_ToEvolveList";
            this.checkedList_ToEvolveList.Size = new System.Drawing.Size(180, 289);
            this.checkedList_ToEvolveList.TabIndex = 1;
            // 
            // Tab_Settings_Page_TransferSettings
            // 
            this.Tab_Settings_Page_TransferSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Settings_Page_TransferSettings.Controls.Add(this.GroupBox_TransferPokemon);
            this.Tab_Settings_Page_TransferSettings.Controls.Add(this.GroupBox_ToNotTransferList);
            this.Tab_Settings_Page_TransferSettings.Location = new System.Drawing.Point(134, 4);
            this.Tab_Settings_Page_TransferSettings.Name = "Tab_Settings_Page_TransferSettings";
            this.Tab_Settings_Page_TransferSettings.Size = new System.Drawing.Size(638, 371);
            this.Tab_Settings_Page_TransferSettings.TabIndex = 4;
            this.Tab_Settings_Page_TransferSettings.Text = "Transfer Settings";
            // 
            // GroupBox_TransferPokemon
            // 
            this.GroupBox_TransferPokemon.Controls.Add(this.OnOff_TransferPokemon);
            this.GroupBox_TransferPokemon.DrawSeperator = false;
            this.GroupBox_TransferPokemon.Location = new System.Drawing.Point(6, 6);
            this.GroupBox_TransferPokemon.Name = "GroupBox_TransferPokemon";
            this.GroupBox_TransferPokemon.Size = new System.Drawing.Size(298, 276);
            this.GroupBox_TransferPokemon.SubTitle = "Details";
            this.GroupBox_TransferPokemon.TabIndex = 5;
            this.GroupBox_TransferPokemon.Text = "GroupBox_TransferPokemon";
            this.GroupBox_TransferPokemon.Title = "Transfer Pokemon";
            // 
            // OnOff_TransferPokemon
            // 
            this.OnOff_TransferPokemon.Checked = false;
            this.OnOff_TransferPokemon.Location = new System.Drawing.Point(239, 3);
            this.OnOff_TransferPokemon.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_TransferPokemon.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_TransferPokemon.Name = "OnOff_TransferPokemon";
            this.OnOff_TransferPokemon.Size = new System.Drawing.Size(56, 24);
            this.OnOff_TransferPokemon.TabIndex = 0;
            this.OnOff_TransferPokemon.Text = "OnOff_TransferPokemon";
            // 
            // GroupBox_ToNotTransferList
            // 
            this.GroupBox_ToNotTransferList.Controls.Add(this.Button_TransferListUnselectAll);
            this.GroupBox_ToNotTransferList.Controls.Add(this.Button_TransferListSelectAll);
            this.GroupBox_ToNotTransferList.Controls.Add(this.OnOff_ToNotTransferList);
            this.GroupBox_ToNotTransferList.Controls.Add(this.checkedList_ToNotTransferList);
            this.GroupBox_ToNotTransferList.DrawSeperator = false;
            this.GroupBox_ToNotTransferList.Location = new System.Drawing.Point(443, 6);
            this.GroupBox_ToNotTransferList.Name = "GroupBox_ToNotTransferList";
            this.GroupBox_ToNotTransferList.Size = new System.Drawing.Size(192, 359);
            this.GroupBox_ToNotTransferList.SubTitle = "Details";
            this.GroupBox_ToNotTransferList.TabIndex = 4;
            this.GroupBox_ToNotTransferList.Text = "GroupBox_ToNotTransferList";
            this.GroupBox_ToNotTransferList.Title = "Not Transfer List";
            // 
            // Button_TransferListUnselectAll
            // 
            this.Button_TransferListUnselectAll.Location = new System.Drawing.Point(105, 333);
            this.Button_TransferListUnselectAll.Name = "Button_TransferListUnselectAll";
            this.Button_TransferListUnselectAll.Size = new System.Drawing.Size(81, 23);
            this.Button_TransferListUnselectAll.TabIndex = 6;
            this.Button_TransferListUnselectAll.Text = "Unselect All";
            this.Button_TransferListUnselectAll.Click += new System.EventHandler(this.Button_TransferListUnselectAll_Click);
            // 
            // Button_TransferListSelectAll
            // 
            this.Button_TransferListSelectAll.Location = new System.Drawing.Point(6, 333);
            this.Button_TransferListSelectAll.Name = "Button_TransferListSelectAll";
            this.Button_TransferListSelectAll.Size = new System.Drawing.Size(66, 23);
            this.Button_TransferListSelectAll.TabIndex = 5;
            this.Button_TransferListSelectAll.Text = "Select All";
            this.Button_TransferListSelectAll.Click += new System.EventHandler(this.Button_TransferListSelectAll_Click);
            // 
            // OnOff_ToNotTransferList
            // 
            this.OnOff_ToNotTransferList.Checked = false;
            this.OnOff_ToNotTransferList.Location = new System.Drawing.Point(133, 3);
            this.OnOff_ToNotTransferList.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_ToNotTransferList.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_ToNotTransferList.Name = "OnOff_ToNotTransferList";
            this.OnOff_ToNotTransferList.Size = new System.Drawing.Size(56, 24);
            this.OnOff_ToNotTransferList.TabIndex = 2;
            this.OnOff_ToNotTransferList.Text = "OnOff_ToNotTransferList";
            // 
            // checkedList_ToNotTransferList
            // 
            this.checkedList_ToNotTransferList.FormattingEnabled = true;
            this.checkedList_ToNotTransferList.Items.AddRange(new object[] {
            "Bulbasaur",
            "Ivysaur",
            "Venusaur",
            "Charmander",
            "Charmeleon",
            "Charizard",
            "Squirtle",
            "Wartortle",
            "Blastoise",
            "Caterpie",
            "Metapod",
            "Butterfree",
            "Weedle",
            "Kakuna",
            "Beedrill",
            "Pidgey",
            "Pidgeotto",
            "Pidgeot",
            "Rattata",
            "Raticate",
            "Spearow",
            "Fearow",
            "Ekans",
            "Arbok",
            "Pikachu",
            "Raichu",
            "Sandshrew",
            "Sandslash",
            "NidoranFemale",
            "Nidorina",
            "Nidoqueen",
            "NidoranMale",
            "Nidorino",
            "Nidoking",
            "Clefairy",
            "Clefable",
            "Vulpix",
            "Ninetales",
            "Jigglypuff",
            "Wigglytuff",
            "Zubat",
            "Golbat",
            "Oddish",
            "Gloom",
            "Vileplume",
            "Paras",
            "Parasect",
            "Venonat",
            "Venomoth",
            "Diglett",
            "Dugtrio",
            "Meowth",
            "Persian",
            "Psyduck",
            "Golduck",
            "Mankey",
            "Primeape",
            "Growlithe",
            "Arcanine",
            "Poliwag",
            "Poliwhirl",
            "Poliwrath",
            "Abra",
            "Kadabra",
            "Alakazam",
            "Machop",
            "Machoke",
            "Machamp",
            "Bellsprout",
            "Weepinbell",
            "Victreebel",
            "Tentacool",
            "Tentacruel",
            "Geodude",
            "Graveler",
            "Golem",
            "Ponyta",
            "Rapidash",
            "Slowpoke",
            "Slowbro",
            "Magnemite",
            "Magneton",
            "Farfetchd",
            "Doduo",
            "Dodrio",
            "Seel",
            "Dewgong",
            "Grimer",
            "Muk",
            "Shellder",
            "Cloyster",
            "Gastly",
            "Haunter",
            "Gengar",
            "Onix",
            "Drowzee",
            "Hypno",
            "Krabby",
            "Kingler",
            "Voltorb",
            "Electrode",
            "Exeggcute",
            "Exeggutor",
            "Cubone",
            "Marowak",
            "Hitmonlee",
            "Hitmonchan",
            "Lickitung",
            "Koffing",
            "Weezing",
            "Rhyhorn",
            "Rhydon",
            "Chansey",
            "Tangela",
            "Kangaskhan",
            "Horsea",
            "Seadra",
            "Goldeen",
            "Seaking",
            "Staryu",
            "Starmie",
            "MrMime",
            "Scyther",
            "Jynx",
            "Electabuzz",
            "Magmar",
            "Pinsir",
            "Tauros",
            "Magikarp",
            "Gyarados",
            "Lapras",
            "Ditto",
            "Eevee",
            "Vaporeon",
            "Jolteon",
            "Flareon",
            "Porygon",
            "Omanyte",
            "Omastar",
            "Kabuto",
            "Kabutops",
            "Aerodactyl",
            "Snorlax",
            "Articuno",
            "Zapdos",
            "Moltres",
            "Dratini",
            "Dragonair",
            "Dragonite",
            "Mewtwo",
            "Mew"});
            this.checkedList_ToNotTransferList.Location = new System.Drawing.Point(6, 40);
            this.checkedList_ToNotTransferList.Name = "checkedList_ToNotTransferList";
            this.checkedList_ToNotTransferList.Size = new System.Drawing.Size(180, 289);
            this.checkedList_ToNotTransferList.TabIndex = 1;
            // 
            // Tab_Settings_Page_InventorySettings
            // 
            this.Tab_Settings_Page_InventorySettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Settings_Page_InventorySettings.Location = new System.Drawing.Point(134, 4);
            this.Tab_Settings_Page_InventorySettings.Name = "Tab_Settings_Page_InventorySettings";
            this.Tab_Settings_Page_InventorySettings.Size = new System.Drawing.Size(638, 371);
            this.Tab_Settings_Page_InventorySettings.TabIndex = 6;
            this.Tab_Settings_Page_InventorySettings.Text = "Inventory Settings";
            // 
            // Tab_Settings_Page_UseItemsSettings
            // 
            this.Tab_Settings_Page_UseItemsSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Settings_Page_UseItemsSettings.Controls.Add(this.nsGroupBox3);
            this.Tab_Settings_Page_UseItemsSettings.Controls.Add(this.nsGroupBox2);
            this.Tab_Settings_Page_UseItemsSettings.Location = new System.Drawing.Point(134, 4);
            this.Tab_Settings_Page_UseItemsSettings.Name = "Tab_Settings_Page_UseItemsSettings";
            this.Tab_Settings_Page_UseItemsSettings.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Settings_Page_UseItemsSettings.Size = new System.Drawing.Size(638, 371);
            this.Tab_Settings_Page_UseItemsSettings.TabIndex = 1;
            this.Tab_Settings_Page_UseItemsSettings.Text = "Use Items Settings";
            // 
            // nsGroupBox3
            // 
            this.nsGroupBox3.Controls.Add(this.nsOnOffBox3);
            this.nsGroupBox3.Controls.Add(this.nsLabel4);
            this.nsGroupBox3.Controls.Add(this.nsOnOffBox2);
            this.nsGroupBox3.DrawSeperator = false;
            this.nsGroupBox3.Location = new System.Drawing.Point(203, 6);
            this.nsGroupBox3.Name = "nsGroupBox3";
            this.nsGroupBox3.Size = new System.Drawing.Size(200, 74);
            this.nsGroupBox3.SubTitle = "Details";
            this.nsGroupBox3.TabIndex = 2;
            this.nsGroupBox3.Text = "nsGroupBox3";
            this.nsGroupBox3.Title = "Hatch Eggs";
            // 
            // nsOnOffBox3
            // 
            this.nsOnOffBox3.Checked = false;
            this.nsOnOffBox3.Location = new System.Drawing.Point(141, 40);
            this.nsOnOffBox3.MaximumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox3.MinimumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox3.Name = "nsOnOffBox3";
            this.nsOnOffBox3.Size = new System.Drawing.Size(56, 24);
            this.nsOnOffBox3.TabIndex = 8;
            this.nsOnOffBox3.Text = "nsOnOffBox3";
            // 
            // nsLabel4
            // 
            this.nsLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel4.Location = new System.Drawing.Point(3, 43);
            this.nsLabel4.Name = "nsLabel4";
            this.nsLabel4.Size = new System.Drawing.Size(130, 15);
            this.nsLabel4.TabIndex = 7;
            this.nsLabel4.Text = "nsLabel4";
            this.nsLabel4.Value1 = "UseOnly";
            this.nsLabel4.Value2 = "BasicIncubator";
            // 
            // nsOnOffBox2
            // 
            this.nsOnOffBox2.Checked = false;
            this.nsOnOffBox2.Location = new System.Drawing.Point(141, 0);
            this.nsOnOffBox2.MaximumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox2.MinimumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox2.Name = "nsOnOffBox2";
            this.nsOnOffBox2.Size = new System.Drawing.Size(56, 24);
            this.nsOnOffBox2.TabIndex = 0;
            this.nsOnOffBox2.Text = "nsOnOffBox2";
            // 
            // nsGroupBox2
            // 
            this.nsGroupBox2.Controls.Add(this.nsOnOffBox1);
            this.nsGroupBox2.DrawSeperator = false;
            this.nsGroupBox2.Location = new System.Drawing.Point(6, 6);
            this.nsGroupBox2.Name = "nsGroupBox2";
            this.nsGroupBox2.Size = new System.Drawing.Size(191, 37);
            this.nsGroupBox2.SubTitle = "Details";
            this.nsGroupBox2.TabIndex = 1;
            this.nsGroupBox2.Text = "nsGroupBox2";
            this.nsGroupBox2.Title = "Lucky Eggs";
            // 
            // nsOnOffBox1
            // 
            this.nsOnOffBox1.Checked = false;
            this.nsOnOffBox1.Location = new System.Drawing.Point(132, 3);
            this.nsOnOffBox1.MaximumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox1.MinimumSize = new System.Drawing.Size(56, 24);
            this.nsOnOffBox1.Name = "nsOnOffBox1";
            this.nsOnOffBox1.Size = new System.Drawing.Size(56, 24);
            this.nsOnOffBox1.TabIndex = 0;
            this.nsOnOffBox1.Text = "nsOnOffBox1";
            // 
            // Tab_Settings_Page_SecuritySettings
            // 
            this.Tab_Settings_Page_SecuritySettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Settings_Page_SecuritySettings.Controls.Add(this.GroupBox_LogOut);
            this.Tab_Settings_Page_SecuritySettings.Controls.Add(this.GroupBox_DeviceSettings);
            this.Tab_Settings_Page_SecuritySettings.Location = new System.Drawing.Point(134, 4);
            this.Tab_Settings_Page_SecuritySettings.Name = "Tab_Settings_Page_SecuritySettings";
            this.Tab_Settings_Page_SecuritySettings.Size = new System.Drawing.Size(638, 371);
            this.Tab_Settings_Page_SecuritySettings.TabIndex = 7;
            this.Tab_Settings_Page_SecuritySettings.Text = "Security Settings";
            // 
            // GroupBox_LogOut
            // 
            this.GroupBox_LogOut.Controls.Add(this.NumUpDown_LogOut_Runtime);
            this.GroupBox_LogOut.Controls.Add(this.Label_LogOut_Runtime);
            this.GroupBox_LogOut.Controls.Add(this.OnOff_LogOut_Runtime);
            this.GroupBox_LogOut.Controls.Add(this.NumUpDown_LogOut_PokestopsVisit);
            this.GroupBox_LogOut.Controls.Add(this.NumUpDown_LogOut_PokemonCaught);
            this.GroupBox_LogOut.Controls.Add(this.NumUpDown_LogOut_LevelReached);
            this.GroupBox_LogOut.Controls.Add(this.Label_LogOut_PokestopsVisit);
            this.GroupBox_LogOut.Controls.Add(this.OnOff_LogOut_PokestopsVisit);
            this.GroupBox_LogOut.Controls.Add(this.Label_LogOut_PokemonCaught);
            this.GroupBox_LogOut.Controls.Add(this.OnOff_LogOut_PokemonCaught);
            this.GroupBox_LogOut.Controls.Add(this.OnOff_LogOut_LevelReached);
            this.GroupBox_LogOut.Controls.Add(this.Label_LogOut_LevelReached);
            this.GroupBox_LogOut.DrawSeperator = false;
            this.GroupBox_LogOut.Location = new System.Drawing.Point(6, 6);
            this.GroupBox_LogOut.Name = "GroupBox_LogOut";
            this.GroupBox_LogOut.Size = new System.Drawing.Size(274, 157);
            this.GroupBox_LogOut.SubTitle = "Details";
            this.GroupBox_LogOut.TabIndex = 1;
            this.GroupBox_LogOut.Text = "GroupBox_LogOut";
            this.GroupBox_LogOut.Title = "LogOut Settings";
            // 
            // NumUpDown_LogOut_Runtime
            // 
            this.NumUpDown_LogOut_Runtime.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumUpDown_LogOut_Runtime.ForeColor = System.Drawing.SystemColors.Window;
            this.NumUpDown_LogOut_Runtime.Location = new System.Drawing.Point(209, 40);
            this.NumUpDown_LogOut_Runtime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUpDown_LogOut_Runtime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_LogOut_Runtime.Name = "NumUpDown_LogOut_Runtime";
            this.NumUpDown_LogOut_Runtime.Size = new System.Drawing.Size(58, 20);
            this.NumUpDown_LogOut_Runtime.TabIndex = 15;
            this.NumUpDown_LogOut_Runtime.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // Label_LogOut_Runtime
            // 
            this.Label_LogOut_Runtime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_LogOut_Runtime.Location = new System.Drawing.Point(66, 43);
            this.Label_LogOut_Runtime.Name = "Label_LogOut_Runtime";
            this.Label_LogOut_Runtime.Size = new System.Drawing.Size(137, 15);
            this.Label_LogOut_Runtime.TabIndex = 14;
            this.Label_LogOut_Runtime.Text = "Label_LogOut_Runtime";
            this.Label_LogOut_Runtime.Value1 = "Level";
            this.Label_LogOut_Runtime.Value2 = "Runtime (minutes)";
            // 
            // OnOff_LogOut_Runtime
            // 
            this.OnOff_LogOut_Runtime.Checked = false;
            this.OnOff_LogOut_Runtime.Location = new System.Drawing.Point(3, 40);
            this.OnOff_LogOut_Runtime.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_Runtime.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_Runtime.Name = "OnOff_LogOut_Runtime";
            this.OnOff_LogOut_Runtime.Size = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_Runtime.TabIndex = 13;
            this.OnOff_LogOut_Runtime.Text = "OnOff_LogOut_Runtime";
            // 
            // NumUpDown_LogOut_PokestopsVisit
            // 
            this.NumUpDown_LogOut_PokestopsVisit.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumUpDown_LogOut_PokestopsVisit.ForeColor = System.Drawing.SystemColors.Window;
            this.NumUpDown_LogOut_PokestopsVisit.Location = new System.Drawing.Point(209, 127);
            this.NumUpDown_LogOut_PokestopsVisit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUpDown_LogOut_PokestopsVisit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_LogOut_PokestopsVisit.Name = "NumUpDown_LogOut_PokestopsVisit";
            this.NumUpDown_LogOut_PokestopsVisit.Size = new System.Drawing.Size(58, 20);
            this.NumUpDown_LogOut_PokestopsVisit.TabIndex = 12;
            this.NumUpDown_LogOut_PokestopsVisit.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // NumUpDown_LogOut_PokemonCaught
            // 
            this.NumUpDown_LogOut_PokemonCaught.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumUpDown_LogOut_PokemonCaught.ForeColor = System.Drawing.SystemColors.Window;
            this.NumUpDown_LogOut_PokemonCaught.Location = new System.Drawing.Point(209, 98);
            this.NumUpDown_LogOut_PokemonCaught.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUpDown_LogOut_PokemonCaught.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_LogOut_PokemonCaught.Name = "NumUpDown_LogOut_PokemonCaught";
            this.NumUpDown_LogOut_PokemonCaught.Size = new System.Drawing.Size(58, 20);
            this.NumUpDown_LogOut_PokemonCaught.TabIndex = 11;
            this.NumUpDown_LogOut_PokemonCaught.Value = new decimal(new int[] {
            750,
            0,
            0,
            0});
            // 
            // NumUpDown_LogOut_LevelReached
            // 
            this.NumUpDown_LogOut_LevelReached.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumUpDown_LogOut_LevelReached.ForeColor = System.Drawing.SystemColors.Window;
            this.NumUpDown_LogOut_LevelReached.Location = new System.Drawing.Point(209, 69);
            this.NumUpDown_LogOut_LevelReached.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NumUpDown_LogOut_LevelReached.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_LogOut_LevelReached.Name = "NumUpDown_LogOut_LevelReached";
            this.NumUpDown_LogOut_LevelReached.Size = new System.Drawing.Size(58, 20);
            this.NumUpDown_LogOut_LevelReached.TabIndex = 10;
            this.NumUpDown_LogOut_LevelReached.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_LogOut_PokestopsVisit
            // 
            this.Label_LogOut_PokestopsVisit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_LogOut_PokestopsVisit.Location = new System.Drawing.Point(66, 131);
            this.Label_LogOut_PokestopsVisit.Name = "Label_LogOut_PokestopsVisit";
            this.Label_LogOut_PokestopsVisit.Size = new System.Drawing.Size(101, 15);
            this.Label_LogOut_PokestopsVisit.TabIndex = 9;
            this.Label_LogOut_PokestopsVisit.Text = "Label_LogOut_PokestopsVisit";
            this.Label_LogOut_PokestopsVisit.Value1 = "Pokestops";
            this.Label_LogOut_PokestopsVisit.Value2 = "Visit";
            // 
            // OnOff_LogOut_PokestopsVisit
            // 
            this.OnOff_LogOut_PokestopsVisit.Checked = false;
            this.OnOff_LogOut_PokestopsVisit.Location = new System.Drawing.Point(3, 127);
            this.OnOff_LogOut_PokestopsVisit.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_PokestopsVisit.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_PokestopsVisit.Name = "OnOff_LogOut_PokestopsVisit";
            this.OnOff_LogOut_PokestopsVisit.Size = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_PokestopsVisit.TabIndex = 8;
            this.OnOff_LogOut_PokestopsVisit.Text = "OnOff_LogOut_PokestopsVisit";
            // 
            // Label_LogOut_PokemonCaught
            // 
            this.Label_LogOut_PokemonCaught.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_LogOut_PokemonCaught.Location = new System.Drawing.Point(66, 102);
            this.Label_LogOut_PokemonCaught.Name = "Label_LogOut_PokemonCaught";
            this.Label_LogOut_PokemonCaught.Size = new System.Drawing.Size(101, 15);
            this.Label_LogOut_PokemonCaught.TabIndex = 7;
            this.Label_LogOut_PokemonCaught.Text = "Label_LogOut_PokemonCaught";
            this.Label_LogOut_PokemonCaught.Value1 = "Pokemon";
            this.Label_LogOut_PokemonCaught.Value2 = "Caught";
            // 
            // OnOff_LogOut_PokemonCaught
            // 
            this.OnOff_LogOut_PokemonCaught.Checked = false;
            this.OnOff_LogOut_PokemonCaught.Location = new System.Drawing.Point(3, 98);
            this.OnOff_LogOut_PokemonCaught.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_PokemonCaught.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_PokemonCaught.Name = "OnOff_LogOut_PokemonCaught";
            this.OnOff_LogOut_PokemonCaught.Size = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_PokemonCaught.TabIndex = 6;
            this.OnOff_LogOut_PokemonCaught.Text = "OnOff_LogOut_PokemonCaught";
            // 
            // OnOff_LogOut_LevelReached
            // 
            this.OnOff_LogOut_LevelReached.Checked = false;
            this.OnOff_LogOut_LevelReached.Location = new System.Drawing.Point(3, 69);
            this.OnOff_LogOut_LevelReached.MaximumSize = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_LevelReached.MinimumSize = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_LevelReached.Name = "OnOff_LogOut_LevelReached";
            this.OnOff_LogOut_LevelReached.Size = new System.Drawing.Size(56, 24);
            this.OnOff_LogOut_LevelReached.TabIndex = 5;
            this.OnOff_LogOut_LevelReached.Text = "OnOff_LogOut_LevelReached";
            // 
            // Label_LogOut_LevelReached
            // 
            this.Label_LogOut_LevelReached.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_LogOut_LevelReached.Location = new System.Drawing.Point(66, 73);
            this.Label_LogOut_LevelReached.Name = "Label_LogOut_LevelReached";
            this.Label_LogOut_LevelReached.Size = new System.Drawing.Size(101, 15);
            this.Label_LogOut_LevelReached.TabIndex = 4;
            this.Label_LogOut_LevelReached.Text = "Label_LogOut_LevelReached";
            this.Label_LogOut_LevelReached.Value1 = "Level";
            this.Label_LogOut_LevelReached.Value2 = "Reached";
            // 
            // GroupBox_DeviceSettings
            // 
            this.GroupBox_DeviceSettings.Controls.Add(this.Button_NewDeviceId);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_DeviceBrand);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_DeviceBrand);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_FirmwareFingerprint);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_AndroidBoardName);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_AndroidBootloader);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_FirmwareType);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_FirmwareTags);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_FirmwareBrand);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_HardwareModel);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_HardwareManufacturer);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_DeviceModelBoot);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_DeviceModelIdentifier);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_DeviceModel);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_AndroidBootloader);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_AndroidBoardName);
            this.GroupBox_DeviceSettings.Controls.Add(this.TextBox_DeviceId);
            this.GroupBox_DeviceSettings.Controls.Add(this.label1);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_PreconfiguredDevices);
            this.GroupBox_DeviceSettings.Controls.Add(this.ComboBox_PreconfiguredDevices);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_FirmwareFingerprint);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_FirmwareType);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_FirmwareTags);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_FirmwareBrand);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_HardwareModel);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_HardwareManufacturer);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_DeviceModelBoot);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_DeviceModelIdentifier);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_DeviceModel);
            this.GroupBox_DeviceSettings.Controls.Add(this.Label_DeviceId);
            this.GroupBox_DeviceSettings.Controls.Add(this.ComboBox_DeviceType);
            this.GroupBox_DeviceSettings.DrawSeperator = false;
            this.GroupBox_DeviceSettings.Location = new System.Drawing.Point(367, 6);
            this.GroupBox_DeviceSettings.Name = "GroupBox_DeviceSettings";
            this.GroupBox_DeviceSettings.Size = new System.Drawing.Size(268, 359);
            this.GroupBox_DeviceSettings.SubTitle = "Details";
            this.GroupBox_DeviceSettings.TabIndex = 0;
            this.GroupBox_DeviceSettings.Text = "GroupBox_DeviceSettings";
            this.GroupBox_DeviceSettings.Title = "Device Settings";
            // 
            // Button_NewDeviceId
            // 
            this.Button_NewDeviceId.Location = new System.Drawing.Point(85, 69);
            this.Button_NewDeviceId.Name = "Button_NewDeviceId";
            this.Button_NewDeviceId.Size = new System.Drawing.Size(38, 23);
            this.Button_NewDeviceId.TabIndex = 36;
            this.Button_NewDeviceId.Text = "New";
            this.Button_NewDeviceId.Click += new System.EventHandler(this.Button_NewDeviceId_Click);
            // 
            // Label_DeviceBrand
            // 
            this.Label_DeviceBrand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_DeviceBrand.Location = new System.Drawing.Point(3, 139);
            this.Label_DeviceBrand.Name = "Label_DeviceBrand";
            this.Label_DeviceBrand.Size = new System.Drawing.Size(96, 15);
            this.Label_DeviceBrand.TabIndex = 35;
            this.Label_DeviceBrand.Text = "Label_DeviceBrand";
            this.Label_DeviceBrand.Value1 = "Device";
            this.Label_DeviceBrand.Value2 = "Brand";
            // 
            // TextBox_DeviceBrand
            // 
            this.TextBox_DeviceBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DeviceBrand.Location = new System.Drawing.Point(131, 135);
            this.TextBox_DeviceBrand.MaxLength = 32767;
            this.TextBox_DeviceBrand.Multiline = false;
            this.TextBox_DeviceBrand.Name = "TextBox_DeviceBrand";
            this.TextBox_DeviceBrand.ReadOnly = false;
            this.TextBox_DeviceBrand.Size = new System.Drawing.Size(134, 23);
            this.TextBox_DeviceBrand.TabIndex = 34;
            this.TextBox_DeviceBrand.Text = "TextBox_DeviceBrand";
            this.TextBox_DeviceBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_DeviceBrand.UseSystemPasswordChar = false;
            // 
            // TextBox_FirmwareFingerprint
            // 
            this.TextBox_FirmwareFingerprint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_FirmwareFingerprint.Location = new System.Drawing.Point(131, 333);
            this.TextBox_FirmwareFingerprint.MaxLength = 32767;
            this.TextBox_FirmwareFingerprint.Multiline = false;
            this.TextBox_FirmwareFingerprint.Name = "TextBox_FirmwareFingerprint";
            this.TextBox_FirmwareFingerprint.ReadOnly = false;
            this.TextBox_FirmwareFingerprint.Size = new System.Drawing.Size(134, 23);
            this.TextBox_FirmwareFingerprint.TabIndex = 33;
            this.TextBox_FirmwareFingerprint.Text = "TextBox_FirmwareFingerprint";
            this.TextBox_FirmwareFingerprint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_FirmwareFingerprint.UseSystemPasswordChar = false;
            // 
            // Label_AndroidBoardName
            // 
            this.Label_AndroidBoardName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_AndroidBoardName.Location = new System.Drawing.Point(3, 95);
            this.Label_AndroidBoardName.Name = "Label_AndroidBoardName";
            this.Label_AndroidBoardName.Size = new System.Drawing.Size(129, 15);
            this.Label_AndroidBoardName.TabIndex = 12;
            this.Label_AndroidBoardName.Text = "Label_AndroidBoardName";
            this.Label_AndroidBoardName.Value1 = "Android";
            this.Label_AndroidBoardName.Value2 = "BoardName";
            // 
            // Label_AndroidBootloader
            // 
            this.Label_AndroidBootloader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_AndroidBootloader.Location = new System.Drawing.Point(3, 117);
            this.Label_AndroidBootloader.Name = "Label_AndroidBootloader";
            this.Label_AndroidBootloader.Size = new System.Drawing.Size(129, 15);
            this.Label_AndroidBootloader.TabIndex = 13;
            this.Label_AndroidBootloader.Text = "Label_AndroidBootloader";
            this.Label_AndroidBootloader.Value1 = "Android";
            this.Label_AndroidBootloader.Value2 = "Bootloader";
            // 
            // TextBox_FirmwareType
            // 
            this.TextBox_FirmwareType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_FirmwareType.Location = new System.Drawing.Point(131, 311);
            this.TextBox_FirmwareType.MaxLength = 32767;
            this.TextBox_FirmwareType.Multiline = false;
            this.TextBox_FirmwareType.Name = "TextBox_FirmwareType";
            this.TextBox_FirmwareType.ReadOnly = false;
            this.TextBox_FirmwareType.Size = new System.Drawing.Size(134, 23);
            this.TextBox_FirmwareType.TabIndex = 32;
            this.TextBox_FirmwareType.Text = "TextBox_FirmwareType";
            this.TextBox_FirmwareType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_FirmwareType.UseSystemPasswordChar = false;
            // 
            // TextBox_FirmwareTags
            // 
            this.TextBox_FirmwareTags.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_FirmwareTags.Location = new System.Drawing.Point(131, 289);
            this.TextBox_FirmwareTags.MaxLength = 32767;
            this.TextBox_FirmwareTags.Multiline = false;
            this.TextBox_FirmwareTags.Name = "TextBox_FirmwareTags";
            this.TextBox_FirmwareTags.ReadOnly = false;
            this.TextBox_FirmwareTags.Size = new System.Drawing.Size(134, 23);
            this.TextBox_FirmwareTags.TabIndex = 31;
            this.TextBox_FirmwareTags.Text = "TextBox_FirmwareTags";
            this.TextBox_FirmwareTags.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_FirmwareTags.UseSystemPasswordChar = false;
            // 
            // TextBox_FirmwareBrand
            // 
            this.TextBox_FirmwareBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_FirmwareBrand.Location = new System.Drawing.Point(131, 267);
            this.TextBox_FirmwareBrand.MaxLength = 32767;
            this.TextBox_FirmwareBrand.Multiline = false;
            this.TextBox_FirmwareBrand.Name = "TextBox_FirmwareBrand";
            this.TextBox_FirmwareBrand.ReadOnly = false;
            this.TextBox_FirmwareBrand.Size = new System.Drawing.Size(134, 23);
            this.TextBox_FirmwareBrand.TabIndex = 30;
            this.TextBox_FirmwareBrand.Text = "TextBox_FirmwareBrand";
            this.TextBox_FirmwareBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_FirmwareBrand.UseSystemPasswordChar = false;
            // 
            // TextBox_HardwareModel
            // 
            this.TextBox_HardwareModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_HardwareModel.Location = new System.Drawing.Point(131, 245);
            this.TextBox_HardwareModel.MaxLength = 32767;
            this.TextBox_HardwareModel.Multiline = false;
            this.TextBox_HardwareModel.Name = "TextBox_HardwareModel";
            this.TextBox_HardwareModel.ReadOnly = false;
            this.TextBox_HardwareModel.Size = new System.Drawing.Size(134, 23);
            this.TextBox_HardwareModel.TabIndex = 29;
            this.TextBox_HardwareModel.Text = "TextBox_HardwareModel";
            this.TextBox_HardwareModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_HardwareModel.UseSystemPasswordChar = false;
            // 
            // TextBox_HardwareManufacturer
            // 
            this.TextBox_HardwareManufacturer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_HardwareManufacturer.Location = new System.Drawing.Point(131, 223);
            this.TextBox_HardwareManufacturer.MaxLength = 32767;
            this.TextBox_HardwareManufacturer.Multiline = false;
            this.TextBox_HardwareManufacturer.Name = "TextBox_HardwareManufacturer";
            this.TextBox_HardwareManufacturer.ReadOnly = false;
            this.TextBox_HardwareManufacturer.Size = new System.Drawing.Size(134, 23);
            this.TextBox_HardwareManufacturer.TabIndex = 28;
            this.TextBox_HardwareManufacturer.Text = "TextBox_HardwareManufacturer";
            this.TextBox_HardwareManufacturer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_HardwareManufacturer.UseSystemPasswordChar = false;
            // 
            // TextBox_DeviceModelBoot
            // 
            this.TextBox_DeviceModelBoot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DeviceModelBoot.Location = new System.Drawing.Point(131, 201);
            this.TextBox_DeviceModelBoot.MaxLength = 32767;
            this.TextBox_DeviceModelBoot.Multiline = false;
            this.TextBox_DeviceModelBoot.Name = "TextBox_DeviceModelBoot";
            this.TextBox_DeviceModelBoot.ReadOnly = false;
            this.TextBox_DeviceModelBoot.Size = new System.Drawing.Size(134, 23);
            this.TextBox_DeviceModelBoot.TabIndex = 27;
            this.TextBox_DeviceModelBoot.Text = "TextBox_DeviceModelBoot";
            this.TextBox_DeviceModelBoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_DeviceModelBoot.UseSystemPasswordChar = false;
            // 
            // TextBox_DeviceModelIdentifier
            // 
            this.TextBox_DeviceModelIdentifier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DeviceModelIdentifier.Location = new System.Drawing.Point(131, 179);
            this.TextBox_DeviceModelIdentifier.MaxLength = 32767;
            this.TextBox_DeviceModelIdentifier.Multiline = false;
            this.TextBox_DeviceModelIdentifier.Name = "TextBox_DeviceModelIdentifier";
            this.TextBox_DeviceModelIdentifier.ReadOnly = false;
            this.TextBox_DeviceModelIdentifier.Size = new System.Drawing.Size(134, 23);
            this.TextBox_DeviceModelIdentifier.TabIndex = 26;
            this.TextBox_DeviceModelIdentifier.Text = "TextBox_DeviceModelIdentifier";
            this.TextBox_DeviceModelIdentifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_DeviceModelIdentifier.UseSystemPasswordChar = false;
            // 
            // TextBox_DeviceModel
            // 
            this.TextBox_DeviceModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DeviceModel.Location = new System.Drawing.Point(131, 157);
            this.TextBox_DeviceModel.MaxLength = 32767;
            this.TextBox_DeviceModel.Multiline = false;
            this.TextBox_DeviceModel.Name = "TextBox_DeviceModel";
            this.TextBox_DeviceModel.ReadOnly = false;
            this.TextBox_DeviceModel.Size = new System.Drawing.Size(134, 23);
            this.TextBox_DeviceModel.TabIndex = 25;
            this.TextBox_DeviceModel.Text = "TextBox_DeviceModel";
            this.TextBox_DeviceModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_DeviceModel.UseSystemPasswordChar = false;
            // 
            // TextBox_AndroidBootloader
            // 
            this.TextBox_AndroidBootloader.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_AndroidBootloader.Location = new System.Drawing.Point(131, 113);
            this.TextBox_AndroidBootloader.MaxLength = 32767;
            this.TextBox_AndroidBootloader.Multiline = false;
            this.TextBox_AndroidBootloader.Name = "TextBox_AndroidBootloader";
            this.TextBox_AndroidBootloader.ReadOnly = false;
            this.TextBox_AndroidBootloader.Size = new System.Drawing.Size(134, 23);
            this.TextBox_AndroidBootloader.TabIndex = 24;
            this.TextBox_AndroidBootloader.Text = "TextBox_AndroidBootloader";
            this.TextBox_AndroidBootloader.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_AndroidBootloader.UseSystemPasswordChar = false;
            // 
            // TextBox_AndroidBoardName
            // 
            this.TextBox_AndroidBoardName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_AndroidBoardName.Location = new System.Drawing.Point(131, 91);
            this.TextBox_AndroidBoardName.MaxLength = 32767;
            this.TextBox_AndroidBoardName.Multiline = false;
            this.TextBox_AndroidBoardName.Name = "TextBox_AndroidBoardName";
            this.TextBox_AndroidBoardName.ReadOnly = false;
            this.TextBox_AndroidBoardName.Size = new System.Drawing.Size(134, 23);
            this.TextBox_AndroidBoardName.TabIndex = 23;
            this.TextBox_AndroidBoardName.Text = "TextBox_AndroidBoardName";
            this.TextBox_AndroidBoardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_AndroidBoardName.UseSystemPasswordChar = false;
            // 
            // TextBox_DeviceId
            // 
            this.TextBox_DeviceId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_DeviceId.Location = new System.Drawing.Point(131, 69);
            this.TextBox_DeviceId.MaxLength = 32767;
            this.TextBox_DeviceId.Multiline = false;
            this.TextBox_DeviceId.Name = "TextBox_DeviceId";
            this.TextBox_DeviceId.ReadOnly = false;
            this.TextBox_DeviceId.Size = new System.Drawing.Size(134, 23);
            this.TextBox_DeviceId.TabIndex = 22;
            this.TextBox_DeviceId.Text = "TextBox_DeviceId";
            this.TextBox_DeviceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox_DeviceId.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 2);
            this.label1.TabIndex = 20;
            // 
            // Label_PreconfiguredDevices
            // 
            this.Label_PreconfiguredDevices.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_PreconfiguredDevices.Location = new System.Drawing.Point(3, 43);
            this.Label_PreconfiguredDevices.Name = "Label_PreconfiguredDevices";
            this.Label_PreconfiguredDevices.Size = new System.Drawing.Size(120, 15);
            this.Label_PreconfiguredDevices.TabIndex = 19;
            this.Label_PreconfiguredDevices.Text = "Label_PreconfiguredDevices";
            this.Label_PreconfiguredDevices.Value1 = "Preconfigured";
            this.Label_PreconfiguredDevices.Value2 = "Devices";
            // 
            // ComboBox_PreconfiguredDevices
            // 
            this.ComboBox_PreconfiguredDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBox_PreconfiguredDevices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_PreconfiguredDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PreconfiguredDevices.ForeColor = System.Drawing.Color.White;
            this.ComboBox_PreconfiguredDevices.FormattingEnabled = true;
            this.ComboBox_PreconfiguredDevices.Items.AddRange(new object[] {
            "",
            "amazon-fire-cm12",
            "asus-zenfone2",
            "galaxy-note-edge",
            "galaxy-s4",
            "galaxy-s5-gold",
            "galaxy6",
            "galaxy-s7-edge",
            "galaxy-tab3",
            "galaxy-tab-s84",
            "htc10",
            "lg-g4",
            "lg-optimus-f6",
            "lg-optimus-g",
            "lg-v10",
            "melrose-s9",
            "nexus4-chroma",
            "nexus5",
            "nexus-5x",
            "nexus-6p",
            "nexus7gen2",
            "nexus7gen1",
            "note3",
            "sony-z3-compact",
            "xoom",
            "xperia-z5",
            "yureka"});
            this.ComboBox_PreconfiguredDevices.Location = new System.Drawing.Point(129, 40);
            this.ComboBox_PreconfiguredDevices.Name = "ComboBox_PreconfiguredDevices";
            this.ComboBox_PreconfiguredDevices.Size = new System.Drawing.Size(136, 21);
            this.ComboBox_PreconfiguredDevices.TabIndex = 18;
            // 
            // Label_FirmwareFingerprint
            // 
            this.Label_FirmwareFingerprint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_FirmwareFingerprint.Location = new System.Drawing.Point(3, 337);
            this.Label_FirmwareFingerprint.Name = "Label_FirmwareFingerprint";
            this.Label_FirmwareFingerprint.Size = new System.Drawing.Size(129, 15);
            this.Label_FirmwareFingerprint.TabIndex = 17;
            this.Label_FirmwareFingerprint.Text = "Label_FirmwareFingerprint";
            this.Label_FirmwareFingerprint.Value1 = "Firmware";
            this.Label_FirmwareFingerprint.Value2 = "Fingerprint";
            // 
            // Label_FirmwareType
            // 
            this.Label_FirmwareType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_FirmwareType.Location = new System.Drawing.Point(3, 315);
            this.Label_FirmwareType.Name = "Label_FirmwareType";
            this.Label_FirmwareType.Size = new System.Drawing.Size(129, 15);
            this.Label_FirmwareType.TabIndex = 16;
            this.Label_FirmwareType.Text = "Label_FirmwareType";
            this.Label_FirmwareType.Value1 = "Firmware";
            this.Label_FirmwareType.Value2 = "Type";
            // 
            // Label_FirmwareTags
            // 
            this.Label_FirmwareTags.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_FirmwareTags.Location = new System.Drawing.Point(3, 293);
            this.Label_FirmwareTags.Name = "Label_FirmwareTags";
            this.Label_FirmwareTags.Size = new System.Drawing.Size(129, 15);
            this.Label_FirmwareTags.TabIndex = 15;
            this.Label_FirmwareTags.Text = "Label_FirmwareTags";
            this.Label_FirmwareTags.Value1 = "Firmware";
            this.Label_FirmwareTags.Value2 = "Tags";
            // 
            // Label_FirmwareBrand
            // 
            this.Label_FirmwareBrand.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_FirmwareBrand.Location = new System.Drawing.Point(3, 271);
            this.Label_FirmwareBrand.Name = "Label_FirmwareBrand";
            this.Label_FirmwareBrand.Size = new System.Drawing.Size(129, 15);
            this.Label_FirmwareBrand.TabIndex = 14;
            this.Label_FirmwareBrand.Text = "Label_FirmwareBrand";
            this.Label_FirmwareBrand.Value1 = "Firmware";
            this.Label_FirmwareBrand.Value2 = "Brand";
            // 
            // Label_HardwareModel
            // 
            this.Label_HardwareModel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_HardwareModel.Location = new System.Drawing.Point(3, 249);
            this.Label_HardwareModel.Name = "Label_HardwareModel";
            this.Label_HardwareModel.Size = new System.Drawing.Size(129, 15);
            this.Label_HardwareModel.TabIndex = 11;
            this.Label_HardwareModel.Text = "Label_HardwareModel";
            this.Label_HardwareModel.Value1 = "Hardware";
            this.Label_HardwareModel.Value2 = "Model";
            // 
            // Label_HardwareManufacturer
            // 
            this.Label_HardwareManufacturer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_HardwareManufacturer.Location = new System.Drawing.Point(3, 227);
            this.Label_HardwareManufacturer.Name = "Label_HardwareManufacturer";
            this.Label_HardwareManufacturer.Size = new System.Drawing.Size(129, 15);
            this.Label_HardwareManufacturer.TabIndex = 10;
            this.Label_HardwareManufacturer.Text = "Label_HardwareManufacturer";
            this.Label_HardwareManufacturer.Value1 = "Hardware";
            this.Label_HardwareManufacturer.Value2 = "Manufacturer";
            // 
            // Label_DeviceModelBoot
            // 
            this.Label_DeviceModelBoot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_DeviceModelBoot.Location = new System.Drawing.Point(3, 205);
            this.Label_DeviceModelBoot.Name = "Label_DeviceModelBoot";
            this.Label_DeviceModelBoot.Size = new System.Drawing.Size(129, 15);
            this.Label_DeviceModelBoot.TabIndex = 9;
            this.Label_DeviceModelBoot.Text = "Label_DeviceModelBoot";
            this.Label_DeviceModelBoot.Value1 = "Device";
            this.Label_DeviceModelBoot.Value2 = "ModelBoot";
            // 
            // Label_DeviceModelIdentifier
            // 
            this.Label_DeviceModelIdentifier.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_DeviceModelIdentifier.Location = new System.Drawing.Point(3, 183);
            this.Label_DeviceModelIdentifier.Name = "Label_DeviceModelIdentifier";
            this.Label_DeviceModelIdentifier.Size = new System.Drawing.Size(120, 15);
            this.Label_DeviceModelIdentifier.TabIndex = 8;
            this.Label_DeviceModelIdentifier.Text = "Label_DeviceModelIdentifier";
            this.Label_DeviceModelIdentifier.Value1 = "Device";
            this.Label_DeviceModelIdentifier.Value2 = "ModelIdentifier";
            // 
            // Label_DeviceModel
            // 
            this.Label_DeviceModel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_DeviceModel.Location = new System.Drawing.Point(3, 161);
            this.Label_DeviceModel.Name = "Label_DeviceModel";
            this.Label_DeviceModel.Size = new System.Drawing.Size(96, 15);
            this.Label_DeviceModel.TabIndex = 7;
            this.Label_DeviceModel.Text = "Label_DeviceModel";
            this.Label_DeviceModel.Value1 = "Device";
            this.Label_DeviceModel.Value2 = "Model";
            // 
            // Label_DeviceId
            // 
            this.Label_DeviceId.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label_DeviceId.Location = new System.Drawing.Point(3, 73);
            this.Label_DeviceId.Name = "Label_DeviceId";
            this.Label_DeviceId.Size = new System.Drawing.Size(96, 15);
            this.Label_DeviceId.TabIndex = 6;
            this.Label_DeviceId.Text = "Label_DeviceId";
            this.Label_DeviceId.Value1 = "Device";
            this.Label_DeviceId.Value2 = "Id";
            // 
            // ComboBox_DeviceType
            // 
            this.ComboBox_DeviceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ComboBox_DeviceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_DeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_DeviceType.ForeColor = System.Drawing.Color.White;
            this.ComboBox_DeviceType.FormattingEnabled = true;
            this.ComboBox_DeviceType.Items.AddRange(new object[] {
            "Random",
            "Preconfigured",
            "Custom"});
            this.ComboBox_DeviceType.Location = new System.Drawing.Point(148, 3);
            this.ComboBox_DeviceType.Name = "ComboBox_DeviceType";
            this.ComboBox_DeviceType.Size = new System.Drawing.Size(117, 21);
            this.ComboBox_DeviceType.TabIndex = 0;
            this.ComboBox_DeviceType.SelectedIndexChanged += new System.EventHandler(this.nsComboBox1_SelectedIndexChanged_1);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::PokemonGoBot.Properties.Resources.Icon;
            this.Name = "Gui";
            this.Text = "Pokemon GO Bot - Gotta Catch \'Em All - GUI Edition // Version: 2016.8.15.386";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Main.ResumeLayout(false);
            this.TabPage_Main.PerformLayout();
            this.GroupBox_Statistics.ResumeLayout(false);
            this.TabPage_Settings.ResumeLayout(false);
            this.nsTabControl1.ResumeLayout(false);
            this.Tab_Settings_Page_GeneralSettings.ResumeLayout(false);
            this.GroupBox_CSVExpot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_CSVExportInMinutes)).EndInit();
            this.GroupBox_Proxy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_ProxyPort)).EndInit();
            this.GroupBox_Coordinates.ResumeLayout(false);
            this.GroupBox_Login.ResumeLayout(false);
            this.Tab_Settings_Page_MovementSettings.ResumeLayout(false);
            this.GroupBox_GPXPathing.ResumeLayout(false);
            this.nsGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_WalkingSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_MaxTravelDistance)).EndInit();
            this.Tab_Settings_Page_CatchSettings.ResumeLayout(false);
            this.GroupBox_ToNotCatchList.ResumeLayout(false);
            this.GroupBox_CatchPokemon.ResumeLayout(false);
            this.Tab_Settings_Page_EvolveSettings.ResumeLayout(false);
            this.GroupBox_EvolvePokemon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.GroupBox_ToEvolveList.ResumeLayout(false);
            this.Tab_Settings_Page_TransferSettings.ResumeLayout(false);
            this.GroupBox_TransferPokemon.ResumeLayout(false);
            this.GroupBox_ToNotTransferList.ResumeLayout(false);
            this.Tab_Settings_Page_UseItemsSettings.ResumeLayout(false);
            this.nsGroupBox3.ResumeLayout(false);
            this.nsGroupBox2.ResumeLayout(false);
            this.Tab_Settings_Page_SecuritySettings.ResumeLayout(false);
            this.GroupBox_LogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_LogOut_Runtime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_LogOut_PokestopsVisit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_LogOut_PokemonCaught)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_LogOut_LevelReached)).EndInit();
            this.GroupBox_DeviceSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private NSOnOffBox OnOff_DebugMode;
        private NSTextBox Debug_Label;
        private NSTabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Main;
        private System.Windows.Forms.TabPage TabPage_Settings;
        private NSButton Settings_Save;
        private System.Windows.Forms.Label OnlyForDonators_Text;
        private NSButton Bot_Close;
        private System.Windows.Forms.TabPage TabPage_Pokemon;
        private System.Windows.Forms.TabPage TabPage_Inventory;
        private NSTabControl nsTabControl1;
        private System.Windows.Forms.TabPage Tab_Settings_Page_GeneralSettings;
        private System.Windows.Forms.TabPage Tab_Settings_Page_UseItemsSettings;
        private NSGroupBox GroupBox_Login;
        private NSComboBox ComboBox_AuthType;
        private NSTextBox TextBox_UserPassword;
        private NSTextBox TextBox_UserNameOrEmail;
        private NSGroupBox GroupBox_Coordinates;
        private NSTextBox TextBot_Altitude;
        private NSTextBox TextBot_Longitude;
        private NSTextBox TextBot_Latitude;
        private NSGroupBox GroupBox_Proxy;
        private NSOnOffBox OnOff_UseProxy;
        private NSTextBox TextBox_ProxyPassword;
        private NSTextBox TextBox_ProxyUsername;
        private NSTextBox TextBox_ProxyHost;
        private NSLabel Label_ProxyPassword;
        private NSLabel Label_ProxyUsername;
        private NSLabel Label_ProxyPort;
        private NSLabel Label_ProxyHost;
        private NSGroupBox GroupBox_CSVExpot;
        private NSLabel nsLabel1;
        private NSLabel Label_DefaultLatitude;
        private NSLabel Label_DefaultAltitude;
        private NSLabel Label_DefaultLongitude;
        private System.Windows.Forms.NumericUpDown NumUpDown_ProxyPort;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage Tab_Settings_Page_MovementSettings;
        private NSGroupBox GroupBox_GPXPathing;
        private NSOnOffBox OnOff_GPXIgnorePokestops;
        private NSTextBox TextBot_GPXFile;
        private NSButton Button_SelectGPXFile;
        private NSLabel Label_GPXIgnorePokestops;
        private NSLabel Label_GPXFile;
        private NSGroupBox nsGroupBox1;
        private System.Windows.Forms.NumericUpDown NumUpDown_WalkingSpeed;
        private System.Windows.Forms.NumericUpDown NumUpDown_MaxTravelDistance;
        private NSLabel Label_MaxTravelDistance;
        private NSLabel Label_WalkingSpeed;
        private NSComboBox ComboBox_MovementType;
        private System.Windows.Forms.TabPage Tab_Settings_Page_CatchSettings;
        private System.Windows.Forms.TabPage Tab_Settings_Page_EvolveSettings;
        private System.Windows.Forms.TabPage Tab_Settings_Page_TransferSettings;
        private System.Windows.Forms.TabPage Tab_Settings_Page_InventorySettings;
        private NSGroupBox GroupBox_Statistics;
        private NSLabel nsLabel6;
        private NSLabel nsLabel9;
        private NSLabel nsLabel8;
        private NSLabel nsLabel7;
        private NSLabel nsLabel13;
        private NSLabel nsLabel12;
        private NSLabel nsLabel11;
        private NSLabel nsLabel10;
        private NSLabel nsLabel14;
        private NSLabel nsLabel15;
        private NSLabel nsLabel16;
        private NSLabel nsLabel17;
        private NSLabel nsLabel18;
        private NSLabel nsLabel19;
        private NSGroupBox GroupBox_CatchPokemon;
        private NSLabel Label_CatchLuredPokemon;
        private NSLabel Label_CatchIncensePokemon;
        private NSLabel Label_CatchMapPokemon;
        private NSOnOffBox OnOff_CatchLuredPokemon;
        private NSOnOffBox OnOff_CatchIncensePokemon;
        private NSOnOffBox OnOff_CatchMapPokemon;
        private System.Windows.Forms.CheckedListBox checkedList_ToNotCatchList;
        private NSGroupBox GroupBox_ToNotCatchList;
        private NSOnOffBox OnOff_ToNotCatchList;
        private NSGroupBox GroupBox_ToEvolveList;
        private NSOnOffBox OnOff_ToEvolveList;
        private System.Windows.Forms.CheckedListBox checkedList_ToEvolveList;
        private NSGroupBox GroupBox_EvolvePokemon;
        private NSOnOffBox OnOff_EvolvePokemon;
        private NSLabel nsLabel24;
        private NSLabel nsLabel23;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private NSLabel nsLabel2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private NSGroupBox GroupBox_ToNotTransferList;
        private NSOnOffBox OnOff_ToNotTransferList;
        private System.Windows.Forms.CheckedListBox checkedList_ToNotTransferList;
        private NSButton Button_EvolveListSelectAll;
        private NSButton Button_EvolveListUnselectAll;
        private NSButton Button_TransferListUnselectAll;
        private NSButton Button_TransferListSelectAll;
        private NSButton Button_CatchListUnselectAll;
        private NSButton Button_CatchListSelectAll;
        private NSGroupBox GroupBox_TransferPokemon;
        private NSOnOffBox OnOff_TransferPokemon;
        private NSGroupBox nsGroupBox2;
        private NSOnOffBox nsOnOffBox1;
        private NSGroupBox nsGroupBox3;
        private NSOnOffBox nsOnOffBox3;
        private NSLabel nsLabel4;
        private NSOnOffBox nsOnOffBox2;
        private NSGroupBox nsGroupBox4;
        private NSGroupBox nsGroupBox5;
        private System.Windows.Forms.NumericUpDown NumUpDown_CSVExportInMinutes;
        private NSOnOffBox OnOff_UseCSVExport;
        private System.Windows.Forms.TabPage Tab_Settings_Page_SecuritySettings;
        private NSGroupBox GroupBox_DeviceSettings;
        private NSComboBox ComboBox_DeviceType;
        private NSLabel Label_DeviceModel;
        private NSLabel Label_DeviceId;
        private NSLabel Label_DeviceModelBoot;
        private NSLabel Label_DeviceModelIdentifier;
        private NSLabel Label_AndroidBootloader;
        private NSLabel Label_AndroidBoardName;
        private NSLabel Label_HardwareModel;
        private NSLabel Label_HardwareManufacturer;
        private NSLabel Label_FirmwareBrand;
        private NSLabel Label_FirmwareFingerprint;
        private NSLabel Label_FirmwareType;
        private NSLabel Label_FirmwareTags;
        private NSLabel Label_PreconfiguredDevices;
        private NSComboBox ComboBox_PreconfiguredDevices;
        private System.Windows.Forms.Label label1;
        private NSTextBox TextBox_FirmwareType;
        private NSTextBox TextBox_FirmwareTags;
        private NSTextBox TextBox_FirmwareBrand;
        private NSTextBox TextBox_HardwareModel;
        private NSTextBox TextBox_HardwareManufacturer;
        private NSTextBox TextBox_DeviceModelBoot;
        private NSTextBox TextBox_DeviceModelIdentifier;
        private NSTextBox TextBox_DeviceModel;
        private NSTextBox TextBox_AndroidBootloader;
        private NSTextBox TextBox_AndroidBoardName;
        private NSTextBox TextBox_DeviceId;
        private NSTextBox TextBox_FirmwareFingerprint;
        private NSLabel Label_DeviceBrand;
        private NSTextBox TextBox_DeviceBrand;
        private NSGroupBox GroupBox_LogOut;
        private NSLabel Label_LogOut_PokemonCaught;
        private NSOnOffBox OnOff_LogOut_PokemonCaught;
        private NSOnOffBox OnOff_LogOut_LevelReached;
        private NSLabel Label_LogOut_LevelReached;
        private NSLabel Label_LogOut_PokestopsVisit;
        private NSOnOffBox OnOff_LogOut_PokestopsVisit;
        private NumericUpDown NumUpDown_LogOut_PokestopsVisit;
        private NumericUpDown NumUpDown_LogOut_PokemonCaught;
        private NumericUpDown NumUpDown_LogOut_LevelReached;
        private NumericUpDown NumUpDown_LogOut_Runtime;
        private NSLabel Label_LogOut_Runtime;
        private NSOnOffBox OnOff_LogOut_Runtime;
        private TextBox txtConsole;
        private NSButton Button_Start;
        private NSButton Button_Stop;
        private NSButton Button_NewDeviceId;
        public static GMap.NET.WindowsForms.GMapControl gmap;
    }
}

