using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementFifthSpawn : MonoBehaviour
{
    public static bool SixthSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter()
    {
        DepassementFourthSpawn.FifthSpawn = false;
        SixthSpawn = true;
        CollisionFusee.spawn = thisSpawn.transform.position;
    }
}
