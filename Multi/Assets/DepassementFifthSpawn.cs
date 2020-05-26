using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementFifthSpawn : MonoBehaviour
{
    public static bool FifthSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)" || other.gameObject.name == "PlayerSolo(Clone)" || other.gameObject.name == "PlayerSolo")
        {
            FifthSpawn = true;
            DepassementFourthSpawn.FourthSpawn = false;
            CollisionFusee.spawn = thisSpawn.transform.position;
            Destroy(this.gameObject);
        }
    }
}
