using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementThirdSpawn : MonoBehaviour
{
    public static bool FourthSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter()
    {
        DepassementSecondSpawn.ThirdSpawn = false;
        FourthSpawn = true;
        CollisionFusee.spawn = thisSpawn.transform.position;
    }
}
