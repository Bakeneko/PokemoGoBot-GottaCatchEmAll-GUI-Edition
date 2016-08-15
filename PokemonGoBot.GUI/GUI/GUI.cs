using System;
using System.IO;
using System.Windows.Forms;
using PokemonGoBot.GUI.Settings;
using RocketAPI.Enums;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace PokemonGoBot.GUI.GUI
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            ComboBox_AuthType.SelectedItem = ConfigurationManager.AppSettings["AuthType"];
            TextBox_UserNameOrEmail.Text = ConfigurationManager.AppSettings["UserNameOrEmail"];
            TextBox_UserPassword.Text = ConfigurationManager.AppSettings["UserPassword"];

            OnOff_UseProxy.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["UseProxy"]);
            TextBox_ProxyHost.Text = ConfigurationManager.AppSettings["ProxyHost"];
            NumUpDown_ProxyPort.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["ProxyPort"]);
            TextBox_ProxyUsername.Text = ConfigurationManager.AppSettings["ProxyUsername"];
            TextBox_ProxyPassword.Text = ConfigurationManager.AppSettings["ProxyPassword"];

            TextBot_Latitude.Text = ConfigurationManager.AppSettings["DefaultLatitude"];
            TextBot_Longitude.Text = ConfigurationManager.AppSettings["DefaultLongitude"];
            TextBot_Altitude.Text = ConfigurationManager.AppSettings["DefaultAltitude"];

            ComboBox_MovementType.SelectedItem = ConfigurationManager.AppSettings["MovementBy"];
            NumUpDown_WalkingSpeed.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["WalkingSpeedInKilometerPerHour"]);
            NumUpDown_MaxTravelDistance.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["MaxTravelDistanceInMeters"]);

            TextBot_GPXFile.Text = ConfigurationManager.AppSettings["GPXFile"];
            OnOff_GPXIgnorePokestops.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["GPXIgnorePokestops"]);

            OnOff_DebugMode.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["DebugMode"]);
        }

        private void Settings_Save_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["AuthType"].Value = ComboBox_AuthType.SelectedItem.ToString();
            config.AppSettings.Settings["UserNameOrEmail"].Value = TextBox_UserNameOrEmail.Text;
            config.AppSettings.Settings["UserPassword"].Value = TextBox_UserPassword.Text;

            config.AppSettings.Settings["UseProxy"].Value = OnOff_UseProxy.Checked.ToString();
            config.AppSettings.Settings["ProxyHost"].Value = TextBox_ProxyHost.Text;
            config.AppSettings.Settings["ProxyPort"].Value = NumUpDown_ProxyPort.Text;
            config.AppSettings.Settings["ProxyUsername"].Value = TextBox_ProxyUsername.Text;
            config.AppSettings.Settings["ProxyPassword"].Value = TextBox_ProxyPassword.Text;

            config.AppSettings.Settings["DefaultLatitude"].Value = TextBot_Latitude.Text;
            config.AppSettings.Settings["DefaultLongitude"].Value = TextBot_Longitude.Text;
            config.AppSettings.Settings["DefaultAltitude"].Value = TextBot_Altitude.Text;

            config.AppSettings.Settings["MovementBy"].Value = ComboBox_MovementType.SelectedItem.ToString();
            config.AppSettings.Settings["WalkingSpeedInKilometerPerHour"].Value = NumUpDown_WalkingSpeed.Value.ToString();
            config.AppSettings.Settings["MaxTravelDistanceInMeters"].Value = NumUpDown_MaxTravelDistance.Value.ToString();

            config.AppSettings.Settings["GPXFile"].Value = TextBot_GPXFile.Text;
            config.AppSettings.Settings["GPXIgnorePokestops"].Value = OnOff_GPXIgnorePokestops.Checked.ToString();

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

        private void nsTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void nsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nsLabel3_Click(object sender, EventArgs e)
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
    }
}
