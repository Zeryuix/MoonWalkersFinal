using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementThirdSpawn : MonoBehaviour
{
    public static bool FourthSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)")
        {
            DepassementSecondSpawn.ThirdSpawn = false;
            FourthSpawn = true;
            CollisionFusee.spawn = thisSpawn.transform.position;
        }
    }
}
