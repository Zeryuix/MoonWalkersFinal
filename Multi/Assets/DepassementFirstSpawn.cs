using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementFirstSpawn : MonoBehaviour
{
    public static bool FirstSpawn = true;
    public static bool SecondSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter()
    {
        FirstSpawn = false;
        SecondSpawn = true;
        CollisionFusee.spawn = thisSpawn.transform.position;
    }
}
