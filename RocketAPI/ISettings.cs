#region

using System;
using System.Collections.Generic;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using RocketAPI.Enums;

#endregion


namespace RocketAPI
{
    public interface ISettings
    {
        AuthType AuthType { get; set; }
        string UserNameOrEmail { get; set; }
        string UserPassword { get; set; }
        double DefaultLatitude { get; }
        double DefaultLongitude { get; }
        double DefaultAltitude { get; }

        string MovementBy { get; }
        double WalkingSpeedInKilometerPerHour { get; }
        int MaxTravelDistanceInMeters { get; }

        string GPXFile { get; }
        bool GPXIgnorePokestops { get; }

        bool UseProxy { get; }
        string ProxyHost { get; }
        int ProxyPort { get; }
        string ProxyUsername { get; }
        string ProxyPassword { get; }

        bool UseCSVExport { get; }
        int CSVExportInMinutes { get; }

        bool CatchMapPokemon { get; }
        bool CatchIncensePokemon { get; }
        bool CatchLuredPokemon { get; }
        bool UsePokemonToNotCatchList { get; }
        //PokemonToNotCatchList als array noch einbauen

        bool EvolvePokemon { get; }
        bool EvolveOnlyPokemonAboveIV { get; }
        float EvolveOnlyPokemonAboveIVValue { get; }
        int EvolveKeepCandiesValue { get; }
        bool UsePokemonToEvolveList { get; }
        //PokemonToEvolveList als array noch einbauen

        bool TransferPokemon { get; }
        bool NotTransferPokemonsThatCanEvolve { get; }
        bool UseTransferPokemonKeepAllAboveCP { get; }
        int TransferPokemonKeepAllAboveCPValue { get; }
        bool UseTransferPokemonKeepAllAboveIV { get; }
        float TransferPokemonKeepAllAboveIVValue { get; }
        int TransferPokemonKeepAmountHighestCP { get; }
        int TransferPokemonKeepAmountHighestIV { get; }
        bool UsePokemonToNotTransferList { get; }
        //PokemonToTransferList als array noch einbauen

        bool HatchEggs { get; }
        bool UseOnlyBasicIncubator { get; }
        bool UseLuckyEggs { get; }

        bool PrioritizeIVOverCP { get; }
        bool UseHumanizer { get; }

        string DeviceType { get; }
        string DevicePackageName { get; }
        string DeviceId { get; }
        string AndroidBoardName { get; }
        string AndroidBootloader { get; }
        string DeviceBrand { get; }
        string DeviceModel { get; }
        string DeviceModelIdentifier { get; }
        string DeviceModelBoot { get; }
        string HardwareManufacturer { get; }
        string HardwareModel { get; }
        string FirmwareBrand { get; }
        string FirmwareTags { get; }
        string FirmwareType { get; }
        string FirmwareFingerprint { get; }

        bool DebugMode { get; }

        ICollection<KeyValuePair<ItemId, int>> ItemRecycleFilter(IEnumerable<ItemData> myItems);
        ICollection<PokemonId> PokemonsToEvolve { get; }
        ICollection<PokemonId> PokemonsToNotTransfer { get; }
        ICollection<PokemonId> PokemonsToNotCatch { get; }
    }
}