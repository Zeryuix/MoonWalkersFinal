using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSoloGame : MonoBehaviour
{
    public GameObject player_prefab;
    public Transform spawn_point;
    public static GameObject instantiatedPlayer;
    public static bool isSolo;

    private void Start()
    {
        isSolo = true;
        Spawn();
    }

    public void Spawn()
    {
        instantiatedPlayer = Instantiate(player_prefab, spawn_point.position, spawn_point.rotation);
    }
}
