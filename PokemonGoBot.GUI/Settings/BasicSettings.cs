using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace PokemonGoBot.Settings
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
            SettingsKeys.Add("ProxyPort", "0000");
            SettingsKeys.Add("ProxyUsername", "");
            SettingsKeys.Add("ProxyPassword", "");

            SettingsKeys.Add("UseCSVExport", "false");
            SettingsKeys.Add("CSVExportInMinutes", "15"); //In GUI Einbauen

            SettingsKeys.Add("CatchMapPokemon", "true");
            SettingsKeys.Add("CatchIncensePokemon", "false");
            SettingsKeys.Add("CatchLuredPokemon", "false");
            SettingsKeys.Add("UsePokemonToNotCatchList", "false");
            SettingsKeys.Add("PokemonToNotCatchList", "");

            SettingsKeys.Add("EvolvePokemon", "true");
            SettingsKeys.Add("EvolveOnlyPokemonAboveIV", "false"); //In GUI Einbauen
            SettingsKeys.Add("EvolveOnlyPokemonAboveIVValue", "95"); //In GUI Einbauen
            SettingsKeys.Add("EvolveKeepCandiesValue", "200"); //In GUI Einbauen
            SettingsKeys.Add("UsePokemonToEvolveList", "true");
            SettingsKeys.Add("PokemonToEvolveList", "Zubat,Pidgey,Rattata");

            SettingsKeys.Add("TransferPokemon", "true");
            SettingsKeys.Add("NotTransferPokemonsThatCanEvolve", "false"); //In GUI Einbauen
            SettingsKeys.Add("UseTransferPokemonKeepAllAboveCP", "true"); //In GUI Einbauen
            SettingsKeys.Add("TransferPokemonKeepAllAboveCPValue", "2000"); //In GUI Einbauen
            SettingsKeys.Add("UseTransferPokemonKeepAllAboveIV", "true"); //In GUI Einbauen
            SettingsKeys.Add("TransferPokemonKeepAllAboveIVValue", "95"); //In GUI Einbauen
            SettingsKeys.Add("TransferPokemonKeepAmountHighestCP", "1"); //In GUI Einbauen
            SettingsKeys.Add("TransferPokemonKeepAmountHighestIV", "1"); //In GUI Einbauen
            SettingsKeys.Add("UsePokemonToNotTransferList", "true");
            SettingsKeys.Add("PokemonToNotTransferList", "Dragonite,Charizard,Zapdos,Snorlax,Alakazam,Mew,Mewtwo");

            SettingsKeys.Add("UseLuckyEggs", "true"); //In GUI Einbauen
            SettingsKeys.Add("HatchEggs", "true"); //In GUI Einbauen
            SettingsKeys.Add("UseOnlyBasicIncubator", "true"); //In GUI Einbauen

            SettingsKeys.Add("PrioritizeIVOverCP", "true"); //In GUI Einbauen
            SettingsKeys.Add("UseHumanizer", "true"); //In GUI Einbauen

            SettingsKeys.Add("DeviceType", "Random");
            SettingsKeys.Add("DevicePackageName", "");
            SettingsKeys.Add("DeviceId", "8525f5d8201f78b5");
            SettingsKeys.Add("AndroidBoardName", "msm8996");
            SettingsKeys.Add("AndroidBootloader", "1.0.0.0000");
            SettingsKeys.Add("DeviceBrand", "HTC");
            SettingsKeys.Add("DeviceModel", "HTC 10");
            SettingsKeys.Add("DeviceModelIdentifier", "pmewl_00531");
            SettingsKeys.Add("DeviceModelBoot", "qcom");
            SettingsKeys.Add("HardwareManufacturer", "HTC");
            SettingsKeys.Add("HardwareModel", "HTC 10");
            SettingsKeys.Add("FirmwareBrand", "pmewl_00531");
            SettingsKeys.Add("FirmwareTags", "release - keys");
            SettingsKeys.Add("FirmwareType", "user");
            SettingsKeys.Add("FirmwareFingerprint", "htc/pmewl_00531/htc_pmewl:6.0.1/MMB29M/770927.1:user/release-keys");

            SettingsKeys.Add("LogOut_Runtime", "false"); //In Logic Einbauen
            SettingsKeys.Add("LogOut_Runtime_Value", "300"); //In Logic Einbauen
            SettingsKeys.Add("LogOut_LevelReached", "false"); //In Logic Einbauen
            SettingsKeys.Add("LogOut_LevelReached_Value", "1"); //In Logic Einbauen
            SettingsKeys.Add("LogOut_PokemonCaught", "false"); //In Logic Einbauen
            SettingsKeys.Add("LogOut_PokemonCaught_Value", "750"); //In Logic Einbauen
            SettingsKeys.Add("LogOut_PokestopsVisit", "false"); //In Logic Einbauen
            SettingsKeys.Add("LogOut_PokestopsVisit_Value", "1500"); //In Logic Einbauen

            SettingsKeys.Add("DebugMode", "false");

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
