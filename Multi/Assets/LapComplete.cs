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
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "SmallAsteroid")
        {
            LapTimeManagerSolo.isFinished = true;
            EndScreen.SetActive(true);
            Timer.SetActive(false);
            Look.cursorLocked = false;

            if (LapTimeManagerSolo.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManagerSolo.SecondCount + ".";
            }
            else
            {
                SecondDisplay.GetComponent<Text>().text = "" + LapTimeManagerSolo.SecondCount + ".";
            }

            if (LapTimeManagerSolo.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManagerSolo.MinuteCount + ":";
            }
            else
            {
                MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManagerSolo.MinuteCount + ":";
            }

            MiliDisplay.GetComponent<Text>().text = "" + LapTimeManagerSolo.MilliCount;
            Time.timeScale = 0;
        }
    }
}
