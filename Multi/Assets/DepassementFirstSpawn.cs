using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementFirstSpawn : MonoBehaviour
{
    public static bool FirstSpawn = true;
    public static bool SecondSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)")
        {
            FirstSpawn = false;
            SecondSpawn = true;
            CollisionFusee.spawn = thisSpawn.transform.position;
        }
        else
        {
            Debug.Log(other.gameObject.name);
        }
    }
}
