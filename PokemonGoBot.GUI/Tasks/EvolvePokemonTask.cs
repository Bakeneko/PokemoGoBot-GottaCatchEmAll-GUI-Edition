using System.Linq;
using System.Threading.Tasks;
using PokemonGoBot.Utils;
using POGOProtos.Networking.Responses;
using RocketAPI;
using Logger = PokemonGoBot.Logging.Logger;
using LogLevel = PokemonGoBot.Logging.LogLevel;

namespace PokemonGoBot.Tasks
{
    public class EvolvePokemonTask
    {
        public static async Task Execute()
        {
            await Inventory.GetCachedInventory(true);
            var pokemonToEvolve = await Inventory.GetPokemonToEvolve(Logic._client.Settings.PrioritizeIVOverCP, Logic._client.Settings.PokemonsToEvolve);
            if (pokemonToEvolve == null || !pokemonToEvolve.Any())
                return;

            Logger.Write($"Found {pokemonToEvolve.Count()} Pokemon for Evolve:", LogLevel.Debug);
            foreach (var pokemon in pokemonToEvolve)
            {
                var evolvePokemonOutProto = await Logic._client.Inventory.EvolvePokemon(pokemon.Id);

                await Inventory.GetCachedInventory(true);

                Logger.Write(evolvePokemonOutProto.Result == EvolvePokemonResponse.Types.Result.Success
                        ? $"{pokemon.PokemonId} [CP: {pokemon.Cp}/{PokemonInfo.CalculateMaxCp(pokemon)} | IV: { PokemonInfo.CalculatePokemonPerfection(pokemon).ToString("0.00")}% perfect] | received XP {evolvePokemonOutProto.ExperienceAwarded}"
                        : $"Failed: {pokemon.PokemonId}. EvolvePokemonOutProto.Result was {evolvePokemonOutProto.Result}, stopping evolving {pokemon.PokemonId}"
                    , LogLevel.Evolve);

                if (evolvePokemonOutProto.Result == EvolvePokemonResponse.Types.Result.Success)
                    BotStats.ExperienceThisSession += evolvePokemonOutProto.ExperienceAwarded;
            }
            await BotStats.GetPokeDexCount();
            BotStats.UpdateConsoleTitle();
        }

    }
}
