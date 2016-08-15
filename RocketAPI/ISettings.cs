#region

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
        string GPXFile { get; }
        bool GPXIgnorePokestops { get; }
        double WalkingSpeedInKilometerPerHour { get; }
        int MaxTravelDistanceInMeters { get; }

        bool UsePokemonToNotCatchList { get; }
        bool UsePokemonToNotTransferList { get; }
        bool UsePokemonToEvolveList { get; }
        bool CatchPokemon { get; }
        bool CatchIncensePokemon { get; }
        bool CatchLuredPokemon { get; }
        bool EvolvePokemon { get; }
        bool EvolveOnlyPokemonAboveIV { get; }
        float EvolveOnlyPokemonAboveIVValue { get; }
        int EvolveKeepCandiesValue { get; }

        bool TransferPokemon { get; }
        bool NotTransferPokemonsThatCanEvolve { get; }
        bool UseTransferPokemonKeepAllAboveCP { get; }
        int TransferPokemonKeepAllAboveCPValue { get; }
        bool UseTransferPokemonKeepAllAboveIV { get; }
        float TransferPokemonKeepAllAboveIVValue { get; }
        int TransferPokemonKeepAmountHighestCP { get; }
        int TransferPokemonKeepAmountHighestIV { get; }

        bool HatchEggs { get; }
        bool UseOnlyBasicIncubator { get; }
        bool UseLuckyEggs { get; }
        bool PrioritizeIVOverCP { get; }
        int ExportPokemonToCsvEveryMinutes { get; }
        bool DebugMode { get; }
        string DevicePackageName { get; }
        bool UseHumanizer { get; }

        ICollection<KeyValuePair<ItemId, int>> ItemRecycleFilter(IEnumerable<ItemData> myItems);
        ICollection<PokemonId> PokemonsToEvolve { get; }
        ICollection<PokemonId> PokemonsToNotTransfer { get; }
        ICollection<PokemonId> PokemonsToNotCatch { get; }
    }
}