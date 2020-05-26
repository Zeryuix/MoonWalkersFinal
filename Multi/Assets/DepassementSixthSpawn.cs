using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementSixthSpawn : MonoBehaviour
{
    public static bool SixthSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)" || other.gameObject.name == "PlayerSolo(Clone)" || other.gameObject.name == "PlayerSolo")
        {
            SixthSpawn = true;
            DepassementFifthSpawn.FifthSpawn = false;
            CollisionFusee.spawn = thisSpawn.transform.position;
            Destroy(this.gameObject);
        }
    }
}
