using System;
using System.Threading.Tasks;
using POGOProtos.Inventory.Item;
using POGOProtos.Networking.Responses;
using Logger = PokemonGoBot.Logic.Logging.Logger;
using LogLevel = PokemonGoBot.Logic.Logging.LogLevel;

namespace PokemonGoBot.Logic.Tasks
{
    public class UseLuckyEggTask
    {
        private static DateTime _lastLuckyEggTime;

        public static async Task Execute()
        {
            var currentAmountOfLuckyEggs = await Inventory.GetItemAmountByType(ItemId.ItemLuckyEgg);
            if (currentAmountOfLuckyEggs <= 0 || _lastLuckyEggTime.AddMinutes(30).Ticks > DateTime.Now.Ticks)
                return;

            var UseEgg = await Logic._client.Inventory.UseItemXpBoost();
            if (UseEgg.Result == UseItemXpBoostResponse.Types.Result.ErrorXpBoostAlreadyActive)
                return;

            if (UseEgg.Result == UseItemXpBoostResponse.Types.Result.Success)
            {
                _lastLuckyEggTime = DateTime.Now;
                Logger.Write($"Used Lucky Egg [Remaining: {currentAmountOfLuckyEggs - 1}]", LogLevel.Egg);
            }
            else if (UseEgg.Result == UseItemXpBoostResponse.Types.Result.ErrorNoItemsRemaining)
            {
                Logger.Write($"No Eggs Available", LogLevel.Debug);
            }
            else if (UseEgg.Result == UseItemXpBoostResponse.Types.Result.ErrorXpBoostAlreadyActive || (UseEgg.AppliedItems == null))
            {
                Logger.Write($"Lucky Egg Already Active", LogLevel.Debug);
            }
        }
    }
}
