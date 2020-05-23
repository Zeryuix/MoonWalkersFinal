using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnAsteroid : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SmallAsteroid" || other.gameObject.name == "SmallAsteroid(Clone)")
        {
            Destroy(other.gameObject);
        }
    }
}
