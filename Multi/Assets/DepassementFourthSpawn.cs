using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementFourthSpawn : MonoBehaviour
{
    public static bool FifthSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter()
    {
        DepassementThirdSpawn.FourthSpawn = false;
        FifthSpawn = true;
        CollisionFusee.spawn = thisSpawn.transform.position;
    }
}
