using System;
using System.Collections;
using System.Collections.Generic;
using Com.MoonDevs.MoonWalkers;
using UnityEngine;
using UnityEngine.Rendering.Experimental.LookDev;
using UnityEngine.UI;
using Motion = Com.MoonDevs.MoonWalkers.Motion;

public class Progression : MonoBehaviour
{
    public GameObject FuseePrefab;
    public static int Count;
    public GameObject Box;
    public static int mapSize = 100000;
    public static GameObject Fusee;
    
    void Update()
    {
        if (WaitingTimeChrono.SecondCount >= WaitingTimeChrono.startTimer)
        {
            Count = (int) (Manager.instantiatedPlayer.transform.position.z / mapSize * 100);
            Box.GetComponent<Text>().text = Count + " %";
        }
    }
}
