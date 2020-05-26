using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementSecondSpawn : MonoBehaviour
{
    public static bool SecondSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)" || other.gameObject.name == "PlayerSolo(Clone)" || other.gameObject.name == "PlayerSolo")
        {
            DepassementFirstSpawn.FirstSpawn = false;
            SecondSpawn = true;
            CollisionFusee.spawn = thisSpawn.transform.position;
            Destroy(this.gameObject);
        }
    }
}
