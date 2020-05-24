using System.Collections;
using System.Collections.Generic;
using Com.MoonDevs.MoonWalkers;
using UnityEngine;
using UnityEngine.UI;

public class ProgressionSolo : MonoBehaviour
{
    public GameObject FuseePrefab;
    public static int Count;
    public GameObject Box;
    public static int mapSize = 100000;
    public static GameObject Fusee;
    
    void Update()
    {
        if (WaitingTimeSolo.SecondCount >= WaitingTimeSolo.startTimer)
        {
            Count = (int) (Manager.instantiatedPlayer.transform.position.z / mapSize * 100);
            Box.GetComponent<Text>().text = Count + " %";
        }
    }
}
