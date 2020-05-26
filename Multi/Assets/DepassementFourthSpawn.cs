using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepassementFourthSpawn : MonoBehaviour
{
    public static bool FourthSpawn = false;
    public GameObject thisSpawn;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)" || other.gameObject.name == "PlayerSolo(Clone)" || other.gameObject.name == "PlayerSolo")
        {
            FourthSpawn = true;
            DepassementThirdSpawn.ThirdSpawn = false;
            CollisionFusee.spawn = thisSpawn.transform.position;
            Destroy(this.gameObject);
        }
    }
}
