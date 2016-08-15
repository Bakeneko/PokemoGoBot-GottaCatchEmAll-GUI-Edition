using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonGoBot.Logic.Utils;
using POGOProtos.Map.Pokemon;
using POGOProtos.Networking.Responses;
using Logger = PokemonGoBot.Logic.Logging.Logger;
using LogLevel = PokemonGoBot.Logic.Logging.LogLevel;

namespace PokemonGoBot.Logic.Tasks
{
    public class CatchMapPokemonsTask
    {
        public static async Task Execute()
        {
            if (!Logic._client.Settings.CatchPokemon)
                return;

            var pokemons = await GetNearbyPokemons();
            if (pokemons == null || !pokemons.Any())
                return;

            Logger.Write($"Found {pokemons.Count} catchable Pokemon", LogLevel.Debug);
            foreach (var pokemon in pokemons)
            {
                if (Logic._client.Settings.UsePokemonToNotCatchList && Logic._client.Settings.PokemonsToNotCatch.Contains(pokemon.PokemonId))
                {
                    Logger.Write($"Ignore Pokemon - {pokemon.PokemonId} - is on ToNotCatch List", LogLevel.Debug);
                    continue;
                }

                var encounter = await Logic._client.Encounter.EncounterPokemon(pokemon.EncounterId, pokemon.SpawnPointId);

                if (encounter.Status == EncounterResponse.Types.Status.EncounterSuccess)
                    await CatchPokemonTask.Execute(encounter, pokemon);
                else
                    Logger.Write($"Encounter problem: {encounter.Status}", LogLevel.Warning);
            }

            if (Logic._client.Settings.EvolvePokemon || Logic._client.Settings.EvolveOnlyPokemonAboveIV) await EvolvePokemonTask.Execute();
            if (Logic._client.Settings.TransferPokemon) await TransferPokemonTask.Execute();
        }

        private static async Task<List<MapPokemon>> GetNearbyPokemons()
        {
            var mapObjects = await Logic._client.Map.GetMapObjects();

            var pokemons = mapObjects.Item1.MapCells.SelectMany(i => i.CatchablePokemons)
                .OrderBy(
                    i =>
                        LocationUtils.CalculateDistanceInMeters(Logic._client.CurrentLatitude,
                            Logic._client.CurrentLongitude,
                            i.Latitude, i.Longitude)).ToList();

            return pokemons;
        }

    }
}
