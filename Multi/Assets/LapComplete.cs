using System.Collections;
using System.Collections.Generic;
using Com.MoonDevs.MoonWalkers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject EndScreen;
    public GameObject Timer;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MiliDisplay;
    
    void OnTriggerEnter()
    {
        LapTimeManager.isFinished = true;
        EndScreen.SetActive(true);
        Timer.SetActive(false);
        Look.cursorLocked = false;

        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ":";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ":";
        }

        MiliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
    }
}
