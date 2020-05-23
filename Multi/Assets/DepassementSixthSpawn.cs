using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementSixthSpawn : MonoBehaviour
{
    public static bool LastSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter()
    {
        DepassementFifthSpawn.SixthSpawn = false;
        LastSpawn = true;
        CollisionFusee.spawn = thisSpawn.transform.position;
    }
}
