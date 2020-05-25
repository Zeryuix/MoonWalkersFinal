using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCoins : MonoBehaviour
{
    public GameObject Box;
    
    void Update()
    {
        Box.GetComponent<Text>().text = "" + GetCoins.CountCoins;
    }
}
