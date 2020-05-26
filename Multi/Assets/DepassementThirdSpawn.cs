using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementThirdSpawn : MonoBehaviour
{
    public static bool ThirdSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)" || other.gameObject.name == "PlayerSolo(Clone)" || other.gameObject.name == "PlayerSolo")
        {
            ThirdSpawn = true;
            DepassementSecondSpawn.SecondSpawn = false;
            CollisionFusee.spawn = thisSpawn.transform.position;
            Destroy(this.gameObject);
        }
    }
}
