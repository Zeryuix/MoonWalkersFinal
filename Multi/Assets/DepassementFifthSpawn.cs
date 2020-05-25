using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementFifthSpawn : MonoBehaviour
{
    public static bool SixthSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)")
        {
            DepassementFourthSpawn.FifthSpawn = false;
            SixthSpawn = true;
            CollisionFusee.spawn = thisSpawn.transform.position;
        }
    }
}
