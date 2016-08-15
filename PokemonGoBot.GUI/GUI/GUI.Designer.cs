using PokemonGoBot.GUI.GUI.Theme;

namespace PokemonGoBot.GUI.GUI
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nsTheme1 = new PokemonGoBot.GUI.GUI.Theme.NSTheme();
            this.Bot_Close = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.Settings_Save = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.OnlyForDonators_Text = new System.Windows.Forms.Label();
            this.OnOff_DebugMode = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.Debug_Label = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.TabControl_Main = new PokemonGoBot.GUI.GUI.Theme.NSTabControl();
            this.TabPage_Main = new System.Windows.Forms.TabPage();
            this.TabPage_Pokemon = new System.Windows.Forms.TabPage();
            this.TabPage_Inventory = new System.Windows.Forms.TabPage();
            this.TabPage_Settings = new System.Windows.Forms.TabPage();
            this.nsTabControl1 = new PokemonGoBot.GUI.GUI.Theme.NSTabControl();
            this.Tab_Settings_Page_GeneralSettings = new System.Windows.Forms.TabPage();
            this.GroupBox_Others = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
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
            this.GroupBox_GPXPathing = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.OnOff_GPXIgnorePokestops = new PokemonGoBot.GUI.GUI.Theme.NSOnOffBox();
            this.TextBot_GPXFile = new PokemonGoBot.GUI.GUI.Theme.NSTextBox();
            this.Button_SelectGPXFile = new PokemonGoBot.GUI.GUI.Theme.NSButton();
            this.nsLabel3 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.nsLabel4 = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.GroupBox_Movement = new PokemonGoBot.GUI.GUI.Theme.NSGroupBox();
            this.NumUpDown_WalkingSpeed = new System.Windows.Forms.NumericUpDown();
            this.NumUpDown_MaxTravelDistance = new System.Windows.Forms.NumericUpDown();
            this.Label_MaxTravelDistance = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.Label_WalkingSpeed = new PokemonGoBot.GUI.GUI.Theme.NSLabel();
            this.ComboBox_MovementType = new PokemonGoBot.GUI.GUI.Theme.NSComboBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nsTheme1.SuspendLayout();
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Settings.SuspendLayout();
            this.nsTabControl1.SuspendLayout();
            this.Tab_Settings_Page_GeneralSettings.SuspendLayout();
            this.GroupBox_Others.SuspendLayout();
            this.GroupBox_Proxy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_ProxyPort)).BeginInit();
            this.GroupBox_GPXPathing.SuspendLayout();
            this.GroupBox_Movement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_WalkingSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_MaxTravelDistance)).BeginInit();
            this.GroupBox_Coordinates.SuspendLayout();
            this.GroupBox_Login.SuspendLayout();
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
            this.nsTheme1.Controls.Add(this.Bot_Close);
            this.nsTheme1.Controls.Add(this.Settings_Save);
            this.nsTheme1.Controls.Add(this.OnlyForDonators_Text);
            this.nsTheme1.Controls.Add(this.OnOff_DebugMode);
            this.nsTheme1.Controls.Add(this.Debug_Label);
            this.nsTheme1.Controls.Add(this.TabControl_Main);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(900, 500);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "Pokemon GO Bot - Gotta Catch \'Em All - GUI Edition";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
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
            this.TabControl_Main.ItemSize = new System.Drawing.Size(28, 115);
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
            this.TabPage_Main.Location = new System.Drawing.Point(119, 4);
            this.TabPage_Main.Name = "TabPage_Main";
            this.TabPage_Main.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Main.Size = new System.Drawing.Size(753, 391);
            this.TabPage_Main.TabIndex = 0;
            this.TabPage_Main.Text = "Main";
            // 
            // TabPage_Pokemon
            // 
            this.TabPage_Pokemon.AllowDrop = true;
            this.TabPage_Pokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage_Pokemon.Location = new System.Drawing.Point(119, 4);
            this.TabPage_Pokemon.Name = "TabPage_Pokemon";
            this.TabPage_Pokemon.Size = new System.Drawing.Size(753, 391);
            this.TabPage_Pokemon.TabIndex = 2;
            this.TabPage_Pokemon.Text = "Pokemon";
            // 
            // TabPage_Inventory
            // 
            this.TabPage_Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage_Inventory.Location = new System.Drawing.Point(119, 4);
            this.TabPage_Inventory.Name = "TabPage_Inventory";
            this.TabPage_Inventory.Size = new System.Drawing.Size(753, 391);
            this.TabPage_Inventory.TabIndex = 3;
            this.TabPage_Inventory.Text = "Inventory";
            // 
            // TabPage_Settings
            // 
            this.TabPage_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TabPage_Settings.Controls.Add(this.nsTabControl1);
            this.TabPage_Settings.Location = new System.Drawing.Point(119, 4);
            this.TabPage_Settings.Name = "TabPage_Settings";
            this.TabPage_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Settings.Size = new System.Drawing.Size(753, 391);
            this.TabPage_Settings.TabIndex = 1;
            this.TabPage_Settings.Text = "Settings";
            // 
            // nsTabControl1
            // 
            this.nsTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.nsTabControl1.Controls.Add(this.Tab_Settings_Page_GeneralSettings);
            this.nsTabControl1.Controls.Add(this.tabPage2);
            this.nsTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.nsTabControl1.ItemSize = new System.Drawing.Size(28, 115);
            this.nsTabControl1.Location = new System.Drawing.Point(6, 6);
            this.nsTabControl1.Multiline = true;
            this.nsTabControl1.Name = "nsTabControl1";
            this.nsTabControl1.SelectedIndex = 0;
            this.nsTabControl1.Size = new System.Drawing.Size(744, 379);
            this.nsTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.nsTabControl1.TabIndex = 0;
            // 
            // Tab_Settings_Page_GeneralSettings
            // 
            this.Tab_Settings_Page_GeneralSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_Others);
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_Proxy);
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_GPXPathing);
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_Movement);
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_Coordinates);
            this.Tab_Settings_Page_GeneralSettings.Controls.Add(this.GroupBox_Login);
            this.Tab_Settings_Page_GeneralSettings.Location = new System.Drawing.Point(119, 4);
            this.Tab_Settings_Page_GeneralSettings.Name = "Tab_Settings_Page_GeneralSettings";
            this.Tab_Settings_Page_GeneralSettings.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Settings_Page_GeneralSettings.Size = new System.Drawing.Size(621, 371);
            this.Tab_Settings_Page_GeneralSettings.TabIndex = 0;
            this.Tab_Settings_Page_GeneralSettings.Text = "General Settings";
            // 
            // GroupBox_Others
            // 
            this.GroupBox_Others.Controls.Add(this.nsLabel1);
            this.GroupBox_Others.DrawSeperator = false;
            this.GroupBox_Others.Location = new System.Drawing.Point(321, 186);
            this.GroupBox_Others.Name = "GroupBox_Others";
            this.GroupBox_Others.Size = new System.Drawing.Size(274, 175);
            this.GroupBox_Others.SubTitle = "Details";
            this.GroupBox_Others.TabIndex = 6;
            this.GroupBox_Others.Text = "GroupBox_Others";
            this.GroupBox_Others.Title = "Others";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(3, 39);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(153, 15);
            this.nsLabel1.TabIndex = 9;
            this.nsLabel1.Text = "nsLabel1";
            this.nsLabel1.Value1 = "Export Pokemon";
            this.nsLabel1.Value2 = "to CSV File";
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
            this.GroupBox_Proxy.Location = new System.Drawing.Point(413, 6);
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
            this.NumUpDown_ProxyPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUpDown_ProxyPort.Name = "NumUpDown_ProxyPort";
            this.NumUpDown_ProxyPort.Size = new System.Drawing.Size(58, 20);
            this.NumUpDown_ProxyPort.TabIndex = 11;
            this.NumUpDown_ProxyPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // GroupBox_GPXPathing
            // 
            this.GroupBox_GPXPathing.Controls.Add(this.OnOff_GPXIgnorePokestops);
            this.GroupBox_GPXPathing.Controls.Add(this.TextBot_GPXFile);
            this.GroupBox_GPXPathing.Controls.Add(this.Button_SelectGPXFile);
            this.GroupBox_GPXPathing.Controls.Add(this.nsLabel3);
            this.GroupBox_GPXPathing.Controls.Add(this.nsLabel4);
            this.GroupBox_GPXPathing.DrawSeperator = false;
            this.GroupBox_GPXPathing.Location = new System.Drawing.Point(9, 256);
            this.GroupBox_GPXPathing.Name = "GroupBox_GPXPathing";
            this.GroupBox_GPXPathing.Size = new System.Drawing.Size(208, 93);
            this.GroupBox_GPXPathing.SubTitle = "Details";
            this.GroupBox_GPXPathing.TabIndex = 4;
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
            // nsLabel3
            // 
            this.nsLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel3.Location = new System.Drawing.Point(3, 69);
            this.nsLabel3.Name = "nsLabel3";
            this.nsLabel3.Size = new System.Drawing.Size(115, 21);
            this.nsLabel3.TabIndex = 5;
            this.nsLabel3.Text = "nsLabel3";
            this.nsLabel3.Value1 = "Ignore";
            this.nsLabel3.Value2 = "Pokestops";
            this.nsLabel3.Click += new System.EventHandler(this.nsLabel3_Click);
            // 
            // nsLabel4
            // 
            this.nsLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel4.Location = new System.Drawing.Point(3, 40);
            this.nsLabel4.Name = "nsLabel4";
            this.nsLabel4.Size = new System.Drawing.Size(115, 21);
            this.nsLabel4.TabIndex = 4;
            this.nsLabel4.Text = "nsLabel4";
            this.nsLabel4.Value1 = "GPX";
            this.nsLabel4.Value2 = "File";
            // 
            // GroupBox_Movement
            // 
            this.GroupBox_Movement.Controls.Add(this.NumUpDown_WalkingSpeed);
            this.GroupBox_Movement.Controls.Add(this.NumUpDown_MaxTravelDistance);
            this.GroupBox_Movement.Controls.Add(this.Label_MaxTravelDistance);
            this.GroupBox_Movement.Controls.Add(this.Label_WalkingSpeed);
            this.GroupBox_Movement.Controls.Add(this.ComboBox_MovementType);
            this.GroupBox_Movement.DrawSeperator = false;
            this.GroupBox_Movement.Location = new System.Drawing.Point(9, 152);
            this.GroupBox_Movement.Name = "GroupBox_Movement";
            this.GroupBox_Movement.Size = new System.Drawing.Size(230, 98);
            this.GroupBox_Movement.SubTitle = "Details";
            this.GroupBox_Movement.TabIndex = 3;
            this.GroupBox_Movement.Text = "Movement";
            this.GroupBox_Movement.Title = "Movement";
            // 
            // NumUpDown_WalkingSpeed
            // 
            this.NumUpDown_WalkingSpeed.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NumUpDown_WalkingSpeed.DecimalPlaces = 2;
            this.NumUpDown_WalkingSpeed.ForeColor = System.Drawing.SystemColors.Window;
            this.NumUpDown_WalkingSpeed.Location = new System.Drawing.Point(169, 40);
            this.NumUpDown_WalkingSpeed.Maximum = new decimal(new int[] {
            10000,
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
            1000,
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
            // GroupBox_Coordinates
            // 
            this.GroupBox_Coordinates.Controls.Add(this.Label_DefaultAltitude);
            this.GroupBox_Coordinates.Controls.Add(this.Label_DefaultLongitude);
            this.GroupBox_Coordinates.Controls.Add(this.Label_DefaultLatitude);
            this.GroupBox_Coordinates.Controls.Add(this.TextBot_Altitude);
            this.GroupBox_Coordinates.Controls.Add(this.TextBot_Longitude);
            this.GroupBox_Coordinates.Controls.Add(this.TextBot_Latitude);
            this.GroupBox_Coordinates.DrawSeperator = false;
            this.GroupBox_Coordinates.Location = new System.Drawing.Point(155, 6);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.Location = new System.Drawing.Point(119, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gui";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Settings.ResumeLayout(false);
            this.nsTabControl1.ResumeLayout(false);
            this.Tab_Settings_Page_GeneralSettings.ResumeLayout(false);
            this.GroupBox_Others.ResumeLayout(false);
            this.GroupBox_Proxy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_ProxyPort)).EndInit();
            this.GroupBox_GPXPathing.ResumeLayout(false);
            this.GroupBox_Movement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_WalkingSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown_MaxTravelDistance)).EndInit();
            this.GroupBox_Coordinates.ResumeLayout(false);
            this.GroupBox_Login.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage2;
        private NSGroupBox GroupBox_Login;
        private NSComboBox ComboBox_AuthType;
        private NSTextBox TextBox_UserPassword;
        private NSTextBox TextBox_UserNameOrEmail;
        private NSGroupBox GroupBox_Coordinates;
        private NSTextBox TextBot_Altitude;
        private NSTextBox TextBot_Longitude;
        private NSTextBox TextBot_Latitude;
        private NSGroupBox GroupBox_Movement;
        private NSComboBox ComboBox_MovementType;
        private NSLabel Label_WalkingSpeed;
        private NSLabel Label_MaxTravelDistance;
        private NSGroupBox GroupBox_GPXPathing;
        private NSLabel nsLabel4;
        private NSLabel nsLabel3;
        private System.Windows.Forms.NumericUpDown NumUpDown_MaxTravelDistance;
        private System.Windows.Forms.NumericUpDown NumUpDown_WalkingSpeed;
        private NSGroupBox GroupBox_Proxy;
        private NSOnOffBox OnOff_UseProxy;
        private NSTextBox TextBox_ProxyPassword;
        private NSTextBox TextBox_ProxyUsername;
        private NSTextBox TextBox_ProxyHost;
        private NSLabel Label_ProxyPassword;
        private NSLabel Label_ProxyUsername;
        private NSLabel Label_ProxyPort;
        private NSLabel Label_ProxyHost;
        private NSGroupBox GroupBox_Others;
        private NSLabel nsLabel1;
        private NSLabel Label_DefaultLatitude;
        private NSLabel Label_DefaultAltitude;
        private NSLabel Label_DefaultLongitude;
        private System.Windows.Forms.NumericUpDown NumUpDown_ProxyPort;
        private NSButton Button_SelectGPXFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private NSTextBox TextBot_GPXFile;
        private NSOnOffBox OnOff_GPXIgnorePokestops;
    }
}

