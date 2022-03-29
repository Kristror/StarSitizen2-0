using Characters;
using UnityEngine;
using UnityEngine.Networking;

namespace Main
{
    public class SolarSystemNetworkManager : NetworkManager
    {
        [SerializeField] public string playerName;
        [SerializeField] private float spawnDistance = 1000;

        public override void OnServerAddPlayer(NetworkConnection conn, short playerControllerId)
        {

            var player = Instantiate(playerPrefab, Random.insideUnitSphere*spawnDistance, Quaternion.identity);
            player.GetComponent<ShipController>().PlayerName = playerName;
            player.GetComponent<HealthController>().SpawnDistance = spawnDistance;
            NetworkServer.AddPlayerForConnection(conn, player, playerControllerId);

        }
        
    }
}
