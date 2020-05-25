using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementSecondSpawn : MonoBehaviour
{
    public static bool ThirdSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)")
        {
            DepassementFirstSpawn.SecondSpawn = false;
            ThirdSpawn = true;
            CollisionFusee.spawn = thisSpawn.transform.position;
        }
    }
}
