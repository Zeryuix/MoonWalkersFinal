using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GetCoins : MonoBehaviour
{
    public static int CountCoins;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "SmallAsteroid" && other.gameObject.name != "SmallAsteroid(Clone)")
        {
            CountCoins++;
            Destroy(this.gameObject);
        }
    }
}
