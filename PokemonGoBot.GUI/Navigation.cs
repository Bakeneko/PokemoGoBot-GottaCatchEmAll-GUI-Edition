#region

using System;
using System.Threading.Tasks;
using PokemonGoBot.GUI;
using PokemonGoBot.Logging;
using PokemonGoBot.Utils;
using POGOProtos.Map.Fort;
using POGOProtos.Networking.Responses;
using RocketAPI.Helpers;

#endregion


namespace PokemonGoBot
{
    public class Navigation
    {
        public static async Task<PlayerUpdateResponse> HumanLikeWalking(GeoUtils targetLocation,Func<Task<bool>> functionExecutedWhileWalking)
        {
            double walkingSpeedInKilometersPerHour = RandomHelper.RandomWalkSpeed(Logic._client.Settings.WalkingSpeedInKilometerPerHour);
            var speedInMetersPerSecond = walkingSpeedInKilometersPerHour / 3.6;

            var sourceLocation = new GeoUtils(Logic._client.CurrentLatitude, Logic._client.CurrentLongitude);
            var distanceToTarget = LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation);
            Logger.Write($"Distance to target location: {distanceToTarget:0.##} meters. Will take {distanceToTarget / speedInMetersPerSecond:0.##} seconds!", LogLevel.Navigation);

            var nextWaypointBearing = LocationUtils.DegreeBearing(sourceLocation, targetLocation);
            var nextWaypointDistance = speedInMetersPerSecond;
            var waypoint = LocationUtils.CreateWaypoint(sourceLocation, nextWaypointDistance, nextWaypointBearing);

            //Initial walking
            var requestSendDateTime = DateTime.Now;
            PlayerUpdateResponse result;
            await Logic._client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude, Logic._client.Settings.DefaultAltitude);
            Gui.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude);

            do
            {
                walkingSpeedInKilometersPerHour = RandomHelper.RandomWalkSpeed(Logic._client.Settings.WalkingSpeedInKilometerPerHour);
                speedInMetersPerSecond = walkingSpeedInKilometersPerHour / 3.6;

                var millisecondsUntilGetUpdatePlayerLocationResponse = (DateTime.Now - requestSendDateTime).TotalMilliseconds;

                sourceLocation = new GeoUtils(Logic._client.CurrentLatitude, Logic._client.CurrentLongitude);
                var currentDistanceToTarget = LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation);
                Logger.Write($"Distance to target location: {currentDistanceToTarget:0.##} meters. Will take {currentDistanceToTarget / speedInMetersPerSecond:0.##} seconds with a speed of {walkingSpeedInKilometersPerHour}km/h!", LogLevel.Debug);

                nextWaypointDistance = Math.Min(currentDistanceToTarget,
                    millisecondsUntilGetUpdatePlayerLocationResponse / 1000 * speedInMetersPerSecond);
                nextWaypointBearing = LocationUtils.DegreeBearing(sourceLocation, targetLocation);
                waypoint = LocationUtils.CreateWaypoint(sourceLocation, nextWaypointDistance, nextWaypointBearing);

                requestSendDateTime = DateTime.Now;
                result =
                    await
                        Logic._client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude,
                            Logic._client.Settings.DefaultAltitude);
                Gui.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude);

                if (functionExecutedWhileWalking != null)
                    await functionExecutedWhileWalking();// look for pokemon

            } while (LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation) >= 35);

            return result;
        }

        public static async Task<PlayerUpdateResponse> HumanPathWalking(GpxReader.Trkpt trk, Func<Task<bool>> functionExecutedWhileWalking)
        {
            double walkingSpeedInKilometersPerHour = RandomHelper.RandomWalkSpeed(Logic._client.Settings.WalkingSpeedInKilometerPerHour);
            var speedInMetersPerSecond = walkingSpeedInKilometersPerHour / 3.6;

            var sourceLocation = new GeoUtils(Logic._client.CurrentLatitude, Logic._client.CurrentLongitude);
            var targetLocation = new GeoUtils(Convert.ToDouble(trk.Lat), Convert.ToDouble(trk.Lon));
            var distanceToTarget = LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation);
            Logger.Write($"Distance to target location: {distanceToTarget:0.##} meters. Will take {distanceToTarget/speedInMetersPerSecond:0.##} seconds!", LogLevel.Navigation);

            var nextWaypointBearing = LocationUtils.DegreeBearing(sourceLocation, targetLocation);
            var nextWaypointDistance = speedInMetersPerSecond;
            var waypoint = LocationUtils.CreateWaypoint(sourceLocation, nextWaypointDistance, nextWaypointBearing, Convert.ToDouble(trk.Ele));

            //Initial walking
            var requestSendDateTime = DateTime.Now;
            PlayerUpdateResponse result;
            await Logic._client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude, Logic._client.Settings.DefaultAltitude);

            do
            {
                walkingSpeedInKilometersPerHour = RandomHelper.RandomWalkSpeed(Logic._client.Settings.WalkingSpeedInKilometerPerHour);
                speedInMetersPerSecond = walkingSpeedInKilometersPerHour / 3.6;

                var millisecondsUntilGetUpdatePlayerLocationResponse = (DateTime.Now - requestSendDateTime).TotalMilliseconds;

                sourceLocation = new GeoUtils(Logic._client.CurrentLatitude, Logic._client.CurrentLongitude);
                var currentDistanceToTarget = LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation);
                Logger.Write($"Distance to target location: {currentDistanceToTarget:0.##} meters. Will take {currentDistanceToTarget / speedInMetersPerSecond:0.##} seconds with a speed of {walkingSpeedInKilometersPerHour}km/h!", LogLevel.Debug);

                nextWaypointDistance = Math.Min(currentDistanceToTarget,
                    millisecondsUntilGetUpdatePlayerLocationResponse / 1000 * speedInMetersPerSecond);
                nextWaypointBearing = LocationUtils.DegreeBearing(sourceLocation, targetLocation);
                waypoint = LocationUtils.CreateWaypoint(sourceLocation, nextWaypointDistance, nextWaypointBearing);

                requestSendDateTime = DateTime.Now;
                result =
                    await
                        Logic._client.Player.UpdatePlayerLocation(waypoint.Latitude, waypoint.Longitude,
                            waypoint.Altitude);

                if (functionExecutedWhileWalking != null)
                    await functionExecutedWhileWalking();// look for pokemon

            } while (LocationUtils.CalculateDistanceInMeters(sourceLocation, targetLocation) >= 35);

            return result;
        }

        public static FortData[] PathByNearestNeighbour(FortData[] pokeStops)
        {
            for (var i = 1; i < pokeStops.Length - 1; i++)
            {
                var closest = i + 1;
                var cloestDist = LocationUtils.CalculateDistanceInMeters(pokeStops[i].Latitude, pokeStops[i].Longitude, pokeStops[closest].Latitude, pokeStops[closest].Longitude);
                for (var j = closest; j < pokeStops.Length; j++)
                {
                    var initialDist = cloestDist;
                    var newDist = LocationUtils.CalculateDistanceInMeters(pokeStops[i].Latitude, pokeStops[i].Longitude, pokeStops[j].Latitude, pokeStops[j].Longitude);
                    if (!(initialDist > newDist)) continue;
                    cloestDist = newDist;
                    closest = j;
                }
                var tmpPok = pokeStops[closest];
                pokeStops[closest] = pokeStops[i + 1];
                pokeStops[i + 1] = tmpPok;
            }

            return pokeStops;
        }
    }
}