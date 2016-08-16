#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using RocketAPI;
using RocketAPI.Enums;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using PokemonGoBot.Logging;

#endregion


namespace PokemonGoBot.GUI.Settings
{
    public class Settings : ISettings
    {
        [XmlIgnore]
        public static readonly string ConfigsPath = Path.Combine(Directory.GetCurrentDirectory(), "Settings");
        public static readonly string ConfigsFile = Path.Combine(ConfigsPath, "Settings.xml");

        public AuthType AuthType
        {
            get { return (AuthType)Enum.Parse(typeof(AuthType), ConfigurationManager.AppSettings["AuthType"], true); } set { ConfigurationManager.AppSettings["AuthType"] = value.ToString(); }
        }
        public string UserNameOrEmail
        {
            get { return ConfigurationManager.AppSettings["UserNameOrEmail"]; } set { ConfigurationManager.AppSettings["UserNameOrEmail"] = value; }
        }
        public string UserPassword
        {
            get { return ConfigurationManager.AppSettings["UserPassword"]; } set { ConfigurationManager.AppSettings["UserPassword"] = value; }
        }

        public double DefaultLatitude
        {
            get { return Convert.ToDouble(ConfigurationManager.AppSettings["DefaultLatitude"]); } set { ConfigurationManager.AppSettings["DefaultLatitude"] = value.ToString(); }
        }
        public double DefaultLongitude
        {
            get { return Convert.ToDouble(ConfigurationManager.AppSettings["DefaultLongitude"]); } set { ConfigurationManager.AppSettings["DefaultLongitude"] = value.ToString(); }
        }
        public double DefaultAltitude
        {
            get { return Convert.ToDouble(ConfigurationManager.AppSettings["DefaultAltitude"]); } set { ConfigurationManager.AppSettings["DefaultAltitude"] = value.ToString(); }
        }

        public string MovementBy
        {
            get { return ConfigurationManager.AppSettings["MovementBy"]; } set { ConfigurationManager.AppSettings["MovementBy"] = value; }
        }
        public double WalkingSpeedInKilometerPerHour
        {
            get { return Convert.ToDouble(ConfigurationManager.AppSettings["WalkingSpeedInKilometerPerHour"]); } set { ConfigurationManager.AppSettings["WalkingSpeedInKilometerPerHour"] = value.ToString(); }
        }
        public int MaxTravelDistanceInMeters
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["MaxTravelDistanceInMeters"]); } set { ConfigurationManager.AppSettings["MaxTravelDistanceInMeters"] = value.ToString(); }
        }

        public string GPXFile
        {
            get { return ConfigurationManager.AppSettings["GPXFile"]; } set { ConfigurationManager.AppSettings["GPXFile"] = value; }
        }
        public bool GPXIgnorePokestops
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["GPXIgnorePokestops"]); } set { ConfigurationManager.AppSettings["GPXIgnorePokestops"] = value.ToString(); }
        }

        public bool UseProxy
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseProxy"]); } set { ConfigurationManager.AppSettings["UseProxy"] = value.ToString(); }
        }
        public string ProxyHost
        {
            get { return ConfigurationManager.AppSettings["ProxyHost"]; } set { ConfigurationManager.AppSettings["ProxyHost"] = value; }
        }
        public int ProxyPort
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["ProxyPort"]); } set { ConfigurationManager.AppSettings["ProxyPort"] = value.ToString(); }
        }
        public string ProxyUsername
        {
            get { return ConfigurationManager.AppSettings["ProxyUsername"]; } set { ConfigurationManager.AppSettings["ProxyUsername"] = value; }
        }
        public string ProxyPassword
        {
            get { return ConfigurationManager.AppSettings["ProxyPassword"]; } set { ConfigurationManager.AppSettings["ProxyPassword"] = value; }
        }

        public bool UseCSVExport
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseCSVExport"]); } set { ConfigurationManager.AppSettings["UseCSVExport"] = value.ToString(); }
        }
        public int CSVExportInMinutes
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["CSVExportInMinutes"]); } set { ConfigurationManager.AppSettings["CSVExportInMinutes"] = value.ToString(); }
        }

        public bool CatchMapPokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["CatchMapPokemon"]); } set { ConfigurationManager.AppSettings["CatchMapPokemon"] = value.ToString(); }
        }
        public bool CatchIncensePokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["CatchIncensePokemon"]); } set { ConfigurationManager.AppSettings["CatchIncensePokemon"] = value.ToString(); }
        }
        public bool CatchLuredPokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["CatchLuredPokemon"]); } set { ConfigurationManager.AppSettings["CatchLuredPokemon"] = value.ToString(); }
        }
        public bool UsePokemonToNotCatchList
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UsePokemonToNotCatchList"]); } set { ConfigurationManager.AppSettings["UsePokemonToNotCatchList"] = value.ToString(); }
        }
        //PokemonToNotCatchList als array noch einbauen

        public bool EvolvePokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["EvolvePokemon"]); } set { ConfigurationManager.AppSettings["EvolvePokemon"] = value.ToString(); }
        }
        public bool EvolveOnlyPokemonAboveIV
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["EvolveOnlyPokemonAboveIV"]); } set { ConfigurationManager.AppSettings["EvolveOnlyPokemonAboveIV"] = value.ToString(); }
        }
        public float EvolveOnlyPokemonAboveIVValue
        {
            get { return Convert.ToSingle(ConfigurationManager.AppSettings["EvolveOnlyPokemonAboveIVValue"]); } set { ConfigurationManager.AppSettings["EvolveOnlyPokemonAboveIVValue"] = value.ToString(); }
        }
        public int EvolveKeepCandiesValue
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["EvolveKeepCandiesValue"]); } set { ConfigurationManager.AppSettings["EvolveKeepCandiesValue"] = value.ToString(); }
        }
        public bool UsePokemonToEvolveList
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UsePokemonToEvolveList"]); } set { ConfigurationManager.AppSettings["UsePokemonToEvolveList"] = value.ToString(); }
        }
        //PokemonToEvolveList als array noch einbauen

        public bool TransferPokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["TransferPokemon"]); } set { ConfigurationManager.AppSettings["TransferPokemon"] = value.ToString(); }
        }
        public bool NotTransferPokemonsThatCanEvolve
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["NotTransferPokemonsThatCanEvolve"]); } set { ConfigurationManager.AppSettings["NotTransferPokemonsThatCanEvolve"] = value.ToString(); }
        }
        public bool UseTransferPokemonKeepAllAboveCP
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseTransferPokemonKeepAllAboveCP"]); } set { ConfigurationManager.AppSettings["UseTransferPokemonKeepAllAboveCP"] = value.ToString(); }
        }
        public int TransferPokemonKeepAllAboveCPValue
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["TransferPokemonKeepAllAboveCPValue"]); } set { ConfigurationManager.AppSettings["TransferPokemonKeepAllAboveCPValue"] = value.ToString(); }
        }
        public bool UseTransferPokemonKeepAllAboveIV
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseTransferPokemonKeepAllAboveIV"]); } set { ConfigurationManager.AppSettings["UseTransferPokemonKeepAllAboveIV"] = value.ToString(); }
        }
        public float TransferPokemonKeepAllAboveIVValue
        {
            get { return Convert.ToSingle(ConfigurationManager.AppSettings["TransferPokemonKeepAllAboveIVValue"]); } set { ConfigurationManager.AppSettings["TransferPokemonKeepAllAboveIVValue"] = value.ToString(); }
        }
        public int TransferPokemonKeepAmountHighestCP
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["TransferPokemonKeepAmountHighestCP"]); } set { ConfigurationManager.AppSettings["TransferPokemonKeepAmountHighestCP"] = value.ToString(); }
        }
        public int TransferPokemonKeepAmountHighestIV
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["TransferPokemonKeepAmountHighestIV"]); } set { ConfigurationManager.AppSettings["TransferPokemonKeepAmountHighestIV"] = value.ToString(); }
        }
        public bool UsePokemonToNotTransferList
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UsePokemonToNotTransferList"]); } set { ConfigurationManager.AppSettings["UsePokemonToNotTransferList"] = value.ToString(); }
        }
        //PokemonToTransferList als array noch einbauen

        public bool UseLuckyEggs
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseLuckyEggs"]); } set { ConfigurationManager.AppSettings["UseLuckyEggs"] = value.ToString(); }
        }

        public bool HatchEggs
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["HatchEggs"]); } set { ConfigurationManager.AppSettings["HatchEggs"] = value.ToString(); }
        }
        public bool UseOnlyBasicIncubator
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseOnlyBasicIncubator"]); } set { ConfigurationManager.AppSettings["UseOnlyBasicIncubator"] = value.ToString(); }
        }

        public bool PrioritizeIVOverCP
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["PrioritizeIVOverCP"]); } set { ConfigurationManager.AppSettings["PrioritizeIVOverCP"] = value.ToString(); }
        }
        public bool UseHumanizer
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseHumanizer"]); } set { ConfigurationManager.AppSettings["UseHumanizer"] = value.ToString(); }
        }

        public string DeviceType
        {
            get { return ConfigurationManager.AppSettings["DeviceType"]; } set { ConfigurationManager.AppSettings["DeviceType"] = value; }
        }
        public string DevicePackageName
        {
            get { return ConfigurationManager.AppSettings["DevicePackageName"]; } set { ConfigurationManager.AppSettings["DevicePackageName"] = value; }
        }
        public string DeviceId
        {
            get { return ConfigurationManager.AppSettings["DeviceId"]; } set { ConfigurationManager.AppSettings["DeviceId"] = value; }
        }
        public string AndroidBoardName
        {
            get { return ConfigurationManager.AppSettings["AndroidBoardName"]; } set { ConfigurationManager.AppSettings["DeviceId"] = value; }
        }
        public string AndroidBootloader
        {
            get { return ConfigurationManager.AppSettings["AndroidBootloader"]; } set { ConfigurationManager.AppSettings["AndroidBootloader"] = value; }
        }
        public string DeviceBrand
        {
            get { return ConfigurationManager.AppSettings["DeviceBrand"]; } set { ConfigurationManager.AppSettings["DeviceBrand"] = value; }
        }
        public string DeviceModel
        {
            get { return ConfigurationManager.AppSettings["DeviceModel"]; } set { ConfigurationManager.AppSettings["DeviceModel"] = value; }
        }
        public string DeviceModelIdentifier
        {
            get { return ConfigurationManager.AppSettings["DeviceModelIdentifier"]; } set { ConfigurationManager.AppSettings["DeviceModelIdentifier"] = value; }
        }
        public string DeviceModelBoot
        {
            get { return ConfigurationManager.AppSettings["DeviceModelBoot"]; } set { ConfigurationManager.AppSettings["DeviceModelBoot"] = value; }
        }
        public string HardwareManufacturer
        {
            get { return ConfigurationManager.AppSettings["HardwareManufacturer"]; } set { ConfigurationManager.AppSettings["HardwareManufacturer"] = value; }
        }
        public string HardwareModel
        {
            get { return ConfigurationManager.AppSettings["HardwareModel"]; } set { ConfigurationManager.AppSettings["HardwareModel"] = value; }
        }
        public string FirmwareBrand
        {
            get { return ConfigurationManager.AppSettings["FirmwareBrand"]; } set { ConfigurationManager.AppSettings["FirmwareBrand"] = value; }
        }
        public string FirmwareTags
        {
            get { return ConfigurationManager.AppSettings["FirmwareTags"]; } set { ConfigurationManager.AppSettings["FirmwareTags"] = value; }
        }
        public string FirmwareType
        {
            get { return ConfigurationManager.AppSettings["FirmwareType"]; } set { ConfigurationManager.AppSettings["FirmwareType"] = value; }
        }
        public string FirmwareFingerprint
        {
            get { return ConfigurationManager.AppSettings["FirmwareFingerprint"]; } set { ConfigurationManager.AppSettings["FirmwareFingerprint"] = value; }
        }

        public bool DebugMode
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["DebugMode"]); }
            set { ConfigurationManager.AppSettings["DebugMode"] = value.ToString(); }
        }

        [XmlIgnore]
        private ICollection<PokemonId> _pokemonsToEvolve;

        [XmlIgnore]
        private ICollection<PokemonId> _pokemonsToNotTransfer;

        [XmlIgnore]
        private ICollection<PokemonId> _pokemonsToNotCatch;

        [XmlIgnore]
        private readonly SortedList<int, ItemId> _inventoryBalls = new SortedList<int, ItemId>();
        private readonly SortedList<int, ItemId> _inventoryBerries = new SortedList<int, ItemId>();
        private readonly SortedList<int, ItemId> _inventoryPotions = new SortedList<int, ItemId>();
        private const int MaxBalls = 200;
        private const int MaxBerries = 20;
        private const int MaxPotions = 50;
        public Settings()
        {
            _inventoryBalls.Add(1, ItemId.ItemMasterBall);
            _inventoryBalls.Add(2, ItemId.ItemUltraBall);
            _inventoryBalls.Add(3, ItemId.ItemGreatBall);
            _inventoryBalls.Add(4, ItemId.ItemPokeBall);

            _inventoryPotions.Add(1, ItemId.ItemMaxPotion);
            _inventoryPotions.Add(2, ItemId.ItemHyperPotion);
            _inventoryPotions.Add(3, ItemId.ItemSuperPotion);
            _inventoryPotions.Add(4, ItemId.ItemPotion);

            _inventoryBerries.Add(0, ItemId.ItemPinapBerry);
            _inventoryBerries.Add(1, ItemId.ItemWeparBerry);
            _inventoryBerries.Add(2, ItemId.ItemNanabBerry);
            _inventoryBerries.Add(3, ItemId.ItemBlukBerry);
            _inventoryBerries.Add(4, ItemId.ItemRazzBerry);
        }
        private IDictionary<ItemId, int> _itemRecycleFilter;
        public ICollection<KeyValuePair<ItemId, int>> ItemRecycleFilter(IEnumerable<ItemData> myItems)
        {
            if (_itemRecycleFilter == null)
            {
                _itemRecycleFilter = new Dictionary<ItemId, int>
                {
                    {ItemId.ItemUnknown, 0},
                    {ItemId.ItemRevive, 15},
                    {ItemId.ItemMaxRevive, 25},
                    {ItemId.ItemLuckyEgg, 200},
                    {ItemId.ItemIncenseOrdinary, 100},
                    {ItemId.ItemIncenseSpicy, 100},
                    {ItemId.ItemIncenseCool, 100},
                    {ItemId.ItemIncenseFloral, 100},
                    {ItemId.ItemTroyDisk, 100},
                    {ItemId.ItemXAttack, 100},
                    {ItemId.ItemXDefense, 100},
                    {ItemId.ItemXMiracle, 100},
                    {ItemId.ItemSpecialCamera, 100},
                    {ItemId.ItemIncubatorBasicUnlimited, 100},
                    {ItemId.ItemIncubatorBasic, 100},
                    {ItemId.ItemPokemonStorageUpgrade, 100},
                    {ItemId.ItemItemStorageUpgrade, 100}
                };
            }

            CalculateGroupAmounts(_inventoryBalls, MaxBalls, myItems);
            CalculateGroupAmounts(_inventoryBerries, MaxBerries, myItems);
            CalculateGroupAmounts(_inventoryPotions, MaxPotions, myItems);

            return _itemRecycleFilter;
        }
        private void CalculateGroupAmounts(SortedList<int, ItemId> inventoryGroup, int maxQty, IEnumerable<ItemData> myItems)
        {
            var amountRemaining = maxQty;
            foreach (KeyValuePair<int, ItemId> listItem in inventoryGroup)
            {
                ItemId itemId = listItem.Value;
                int itemQty = 0;

                ItemData item = myItems.FirstOrDefault(x => x.ItemId == itemId);
                if (item != null)
                {
                    itemQty = myItems.FirstOrDefault(x => x.ItemId == itemId).Count;
                }

                var amountToKeep = amountRemaining >= itemQty ? amountRemaining : Math.Min(itemQty, amountRemaining);

                amountRemaining = amountRemaining - itemQty;

                if (amountRemaining < 0)
                {
                    amountRemaining = 0;
                }

                try
                {
                    _itemRecycleFilter[itemId] = amountToKeep;  // Update the filter with amounts to keep
                }
                catch
                {
                    // ignored
                }
            }
        }

        [XmlIgnore]
        public ICollection<PokemonId> PokemonsToEvolve
        {
            get
            {
                //Type of pokemons to evolve
                var defaultPokemon = new List<PokemonId> {
                    PokemonId.Zubat, PokemonId.Pidgey, PokemonId.Rattata
                };
                _pokemonsToEvolve = _pokemonsToEvolve ?? LoadPokemonList("PokemonsToEvolve.ini", defaultPokemon);
                return _pokemonsToEvolve;
            }
        }

        [XmlIgnore]
        public ICollection<PokemonId> PokemonsToNotTransfer
        {
            get
            {
                //Type of pokemons not to transfer
                var defaultPokemon = new List<PokemonId> {
                    PokemonId.Dragonite, PokemonId.Charizard, PokemonId.Zapdos, PokemonId.Snorlax, PokemonId.Alakazam, PokemonId.Mew, PokemonId.Mewtwo
                };
                _pokemonsToNotTransfer = _pokemonsToNotTransfer ?? LoadPokemonList("PokemonsToNotTransfer.ini", defaultPokemon);
                return _pokemonsToNotTransfer;
            }
        }

        [XmlIgnore]
        public ICollection<PokemonId> PokemonsToNotCatch
        {
            get
            {
                //Type of pokemons not to catch
                var defaultPokemon = new List<PokemonId> {
                    PokemonId.Zubat, PokemonId.Pidgey, PokemonId.Rattata
                };
                _pokemonsToNotCatch = _pokemonsToNotCatch ?? LoadPokemonList("PokemonsToNotCatch.ini", defaultPokemon);
                return _pokemonsToNotCatch;
            }
        }

        private ICollection<PokemonId> LoadPokemonList(string filename, List<PokemonId> defaultPokemon)
        {
            ICollection<PokemonId> result = new List<PokemonId>();
            if (!Directory.Exists(ConfigsPath))
                Directory.CreateDirectory(ConfigsPath);
            var pokemonlistFile = Path.Combine(ConfigsPath, filename);
            if (!File.Exists(pokemonlistFile))
            {
                Logger.Write($"Settings File: \"{filename}\" not found, creating new...", LogLevel.Warning);
                using (var w = File.AppendText(pokemonlistFile))
                {
                    defaultPokemon.ForEach(pokemon => w.WriteLine(pokemon.ToString()));
                    defaultPokemon.ForEach(pokemon => result.Add(pokemon));
                    w.Close();
                }
            }

            if (File.Exists(pokemonlistFile))
            {
                Logger.Write($"Loading Settings File: \"{filename}\"", LogLevel.Info);

                string content;
                using (var reader = new StreamReader(pokemonlistFile))
                {
                    content = reader.ReadToEnd();
                    reader.Close();
                }
                content = Regex.Replace(content, @"\\/\*(.|\n)*?\*\/", ""); //todo: supposed to remove comment blocks

                var tr = new StringReader(content);

                var pokemonName = tr.ReadLine();
                while (pokemonName != null)
                {
                    PokemonId pokemon;
                    if (Enum.TryParse(pokemonName, out pokemon))
                    {
                        result.Add(pokemon);
                    }
                    pokemonName = tr.ReadLine();
                }
            }
            return result;
        }
    }
}
