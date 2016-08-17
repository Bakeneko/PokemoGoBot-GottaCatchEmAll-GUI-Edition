using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using PokemonGoBot.GUI;
using PokemonGoBot.Logging;
using PokemonGoBot.Settings;

namespace PokemonGoBot
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var culture = CultureInfo.CreateSpecificCulture("en-US");

            CultureInfo.DefaultThreadCurrentCulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            BasicSettings.CheckAndUpdateFile();
            Logger.SetLogger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gui());

        }
    }
}
