using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkPlayerSpawner : NetworkBehaviour
{
    public GameObject NetworkdPlayerPrefab;
    // void OnStartServer()
    // {
    //     NetworkServer.Spawn();
    // }
    
    public override void OnStartServer()
    {
        // add player at correct spawn position
        //var player = Instantiate(NetworkdPlayerPrefab, transform.position, transform.rotation);
        NetworkServer.Spawn(NetworkdPlayerPrefab);
    }
}
