using System;
using System.IO;
using System.Windows.Forms;
using PokemonGoBot.GUI.GUI;
using PokemonGoBot.GUI.Settings;

namespace PokemonGoBot.GUI
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            BasicSettings.CheckAndUpdateFile();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gui());
        }
    }
}
