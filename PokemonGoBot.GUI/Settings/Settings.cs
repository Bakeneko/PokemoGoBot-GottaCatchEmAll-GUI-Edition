#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using PokemonGoBot.Logic.Logging;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using RocketAPI;
using RocketAPI.Enums;
using System.Configuration;
using System.Windows.Forms;

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
            get { return (AuthType)Enum.Parse(typeof(AuthType), ConfigurationManager.AppSettings["AuthType"], true); }
            set { ConfigurationManager.AppSettings["AuthType"] = value.ToString(); }
        }

        public string UserNameOrEmail
        {
            get { return ConfigurationManager.AppSettings["UserNameOrEmail"]; }
            set { ConfigurationManager.AppSettings["UserNameOrEmail"] = value; }
        }

        public string UserPassword
        {
            get { return ConfigurationManager.AppSettings["UserPassword"]; }
            set { ConfigurationManager.AppSettings["UserPassword"] = value; }
        }

        public double DefaultLatitude
        {
            get { return Convert.ToDouble(ConfigurationManager.AppSettings["DefaultLatitude"]); }
            set { ConfigurationManager.AppSettings["DefaultLatitude"] = value.ToString(); }
        }

        public double DefaultLongitude
        {
            get { return Convert.ToDouble(ConfigurationManager.AppSettings["DefaultLongitude"]); }
            set { ConfigurationManager.AppSettings["DefaultLongitude"] = value.ToString(); }
        }

        public double DefaultAltitude
        {
            get { return Convert.ToDouble(ConfigurationManager.AppSettings["DefaultAltitude"]); }
            set { ConfigurationManager.AppSettings["DefaultAltitude"] = value.ToString(); }
        }

        public string MovementBy
        {
            get { return ConfigurationManager.AppSettings["MovementBy"]; }
            set { ConfigurationManager.AppSettings["MovementBy"] = value; }
        }

        public double WalkingSpeedInKilometerPerHour
        {
            get { return Convert.ToDouble(ConfigurationManager.AppSettings["WalkingSpeedInKilometerPerHour"]); }
            set { ConfigurationManager.AppSettings["WalkingSpeedInKilometerPerHour"] = value.ToString(); }
        }

        public int MaxTravelDistanceInMeters
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["MaxTravelDistanceInMeters"]); }
            set { ConfigurationManager.AppSettings["MaxTravelDistanceInMeters"] = value.ToString(); }
        }

        public string GPXFile
        {
            get { return ConfigurationManager.AppSettings["GPXFile"]; }
            set { ConfigurationManager.AppSettings["GPXFile"] = value; }
        }

        public bool GPXIgnorePokestops
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["GPXIgnorePokestops"]); }
            set { ConfigurationManager.AppSettings["GPXIgnorePokestops"] = value.ToString(); }
        }

        public bool UseProxy
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseProxy"]); }
            set { ConfigurationManager.AppSettings["UseProxy"] = value.ToString(); }
        }

        public int ProxyHost
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["ProxyHost"]); }
            set { ConfigurationManager.AppSettings["ProxyHost"] = value.ToString(); }
        }

        public int ProxyPort
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["ProxyPort"]); }
            set { ConfigurationManager.AppSettings["ProxyPort"] = value.ToString(); }
        }

        public bool ProxyUsername
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["ProxyUsername"]); }
            set { ConfigurationManager.AppSettings["ProxyUsername"] = value.ToString(); }
        }

        public bool ProxyPassword
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["ProxyPassword"]); }
            set { ConfigurationManager.AppSettings["ProxyPassword"] = value.ToString(); }
        }

        public bool UsePokemonToNotCatchList
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UsePokemonToNotCatchList"]); }
            set { ConfigurationManager.AppSettings["UsePokemonToNotCatchList"] = value.ToString(); }
        }

        public bool UsePokemonToNotTransferList
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UsePokemonToNotTransferList"]); }
            set { ConfigurationManager.AppSettings["UsePokemonToNotTransferList"] = value.ToString(); }
        }

        public bool UsePokemonToEvolveList
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UsePokemonToEvolveList"]); }
            set { ConfigurationManager.AppSettings["UsePokemonToEvolveList"] = value.ToString(); }
        }

        public bool CatchPokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["CatchPokemon"]); }
            set { ConfigurationManager.AppSettings["CatchPokemon"] = value.ToString(); }
        }

        public bool CatchIncensePokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["CatchIncensePokemon"]); }
            set { ConfigurationManager.AppSettings["CatchIncensePokemon"] = value.ToString(); }
        }

        public bool CatchLuredPokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["CatchLuredPokemon"]); }
            set { ConfigurationManager.AppSettings["CatchLuredPokemon"] = value.ToString(); }
        }

        public bool EvolvePokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["EvolvePokemon"]); }
            set { ConfigurationManager.AppSettings["EvolvePokemon"] = value.ToString(); }
        }

        public bool EvolveOnlyPokemonAboveIV
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["EvolveOnlyPokemonAboveIV"]); }
            set { ConfigurationManager.AppSettings["EvolveOnlyPokemonAboveIV"] = value.ToString(); }
        }

        public float EvolveOnlyPokemonAboveIVValue
        {
            get { return Convert.ToSingle(ConfigurationManager.AppSettings["EvolveOnlyPokemonAboveIVValue"]); }
            set { ConfigurationManager.AppSettings["EvolveOnlyPokemonAboveIVValue"] = value.ToString(); }
        }

        public int EvolveKeepCandiesValue
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["EvolveKeepCandiesValue"]); }
            set { ConfigurationManager.AppSettings["EvolveKeepCandiesValue"] = value.ToString(); }
        }

        public bool TransferPokemon
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["TransferPokemon"]); }
            set { ConfigurationManager.AppSettings["TransferPokemon"] = value.ToString(); }
        }

        public bool NotTransferPokemonsThatCanEvolve
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["NotTransferPokemonsThatCanEvolve"]); }
            set { ConfigurationManager.AppSettings["NotTransferPokemonsThatCanEvolve"] = value.ToString(); }
        }

        public bool UseTransferPokemonKeepAllAboveCP
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseTransferPokemonKeepAllAboveCP"]); }
            set { ConfigurationManager.AppSettings["UseTransferPokemonKeepAllAboveCP"] = value.ToString(); }
        }

        public int TransferPokemonKeepAllAboveCPValue
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["TransferPokemonKeepAllAboveCPValue"]); }
            set { ConfigurationManager.AppSettings["TransferPokemonKeepAllAboveCPValue"] = value.ToString(); }
        }

        public bool UseTransferPokemonKeepAllAboveIV
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseTransferPokemonKeepAllAboveIV"]); }
            set { ConfigurationManager.AppSettings["UseTransferPokemonKeepAllAboveIV"] = value.ToString(); }
        }

        public float TransferPokemonKeepAllAboveIVValue
        {
            get { return Convert.ToSingle(ConfigurationManager.AppSettings["TransferPokemonKeepAllAboveIVValue"]); }
            set { ConfigurationManager.AppSettings["TransferPokemonKeepAllAboveIVValue"] = value.ToString(); }
        }

        public int TransferPokemonKeepAmountHighestCP
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["TransferPokemonKeepAmountHighestCP"]); }
            set { ConfigurationManager.AppSettings["TransferPokemonKeepAmountHighestCP"] = value.ToString(); }
        }

        public int TransferPokemonKeepAmountHighestIV
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["TransferPokemonKeepAmountHighestIV"]); }
            set { ConfigurationManager.AppSettings["TransferPokemonKeepAmountHighestIV"] = value.ToString(); }
        }

        public bool UseLuckyEggs
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseLuckyEggs"]); }
            set { ConfigurationManager.AppSettings["UseLuckyEggs"] = value.ToString(); }
        }

        public bool HatchEggs
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["HatchEggs"]); }
            set { ConfigurationManager.AppSettings["HatchEggs"] = value.ToString(); }
        }

        public bool UseOnlyBasicIncubator
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseOnlyBasicIncubator"]); }
            set { ConfigurationManager.AppSettings["UseOnlyBasicIncubator"] = value.ToString(); }
        }

        public bool PrioritizeIVOverCP
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["PrioritizeIVOverCP"]); }
            set { ConfigurationManager.AppSettings["PrioritizeIVOverCP"] = value.ToString(); }
        }

        public int ExportPokemonToCsvEveryMinutes
        {
            get { return Convert.ToInt32(ConfigurationManager.AppSettings["ExportPokemonToCsvEveryMinutes"]); }
            set { ConfigurationManager.AppSettings["ExportPokemonToCsvEveryMinutes"] = value.ToString(); }
        }

        public bool DebugMode
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["DebugMode"]); }
            set { ConfigurationManager.AppSettings["DebugMode"] = value.ToString(); }
        }
        public string DevicePackageName
        {
            get { return ConfigurationManager.AppSettings["DevicePackageName"]; }
            set { ConfigurationManager.AppSettings["DevicePackageName"] = value; }
        }
        public bool UseHumanizer
        {
            get { return Convert.ToBoolean(ConfigurationManager.AppSettings["UseHumanizer"]); }
            set { ConfigurationManager.AppSettings["UseHumanizer"] = value.ToString(); }
        }

        [XmlIgnore]
        public string DeviceId = "8525f5d8201f78b5";
        [XmlIgnore]
        public string AndroidBoardName = "msm8996";
        [XmlIgnore]
        public string AndroidBootloader = "1.0.0.0000";
        [XmlIgnore]
        public string DeviceBrand = "HTC";
        [XmlIgnore]
        public string DeviceModel = "HTC 10";
        [XmlIgnore]
        public string DeviceModelIdentifier = "pmewl_00531";
        [XmlIgnore]
        public string DeviceModelBoot = "qcom";
        [XmlIgnore]
        public string HardwareManufacturer = "HTC";
        [XmlIgnore]
        public string HardwareModel = "HTC 10";
        [XmlIgnore]
        public string FirmwareBrand = "pmewl_00531";
        [XmlIgnore]
        public string FirmwareTags = "release - keys";
        [XmlIgnore]
        public string FirmwareType = "user";
        [XmlIgnore]
        public string FirmwareFingerprint = "htc/pmewl_00531/htc_pmewl:6.0.1/MMB29M/770927.1:user/release-keys";

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
