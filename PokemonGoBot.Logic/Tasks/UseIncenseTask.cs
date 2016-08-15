using System;
using System.Threading.Tasks;
using POGOProtos.Inventory.Item;
using POGOProtos.Networking.Responses;
using Logger = PokemonGoBot.Logic.Logging.Logger;
using LogLevel = PokemonGoBot.Logic.Logging.LogLevel;

namespace PokemonGoBot.Logic.Tasks
{
    public class UseIncenseTask
    {
        private static DateTime _lastIncenseTime;

        public static async Task Execute()
        {
            var currentAmountOfIncense = await Inventory.GetItemAmountByType(ItemId.ItemIncenseOrdinary);
            if (currentAmountOfIncense <= 0 || _lastIncenseTime.AddMinutes(30).Ticks > DateTime.Now.Ticks)
                return;

            var UseIncense = await Logic._client.Inventory.UseIncense(ItemId.ItemIncenseOrdinary);
            if (UseIncense.Result == UseIncenseResponse.Types.Result.IncenseAlreadyActive)
                return;

            if (UseIncense.Result == UseIncenseResponse.Types.Result.Success)
            {
                _lastIncenseTime = DateTime.Now;
                Logger.Write($"Used Incense [Remaining: {currentAmountOfIncense - 1}]", LogLevel.Incense);
            }
            else if (UseIncense.Result == UseIncenseResponse.Types.Result.NoneInInventory)
            {
                Logger.Write($"No Incense Available", LogLevel.Debug);
            }
            else if (UseIncense.Result == UseIncenseResponse.Types.Result.IncenseAlreadyActive || (UseIncense.AppliedIncense == null))
            {
                Logger.Write($"Incense Already Active", LogLevel.Debug);
            }
        }
    }
}
