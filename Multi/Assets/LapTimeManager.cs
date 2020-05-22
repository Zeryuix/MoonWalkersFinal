﻿using System.Collections;
using System.Collections.Generic;
using Com.MoonDevs.MoonWalkers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    public static bool isFinished = false;

    void Update()
    {
        if (!isFinished && WaitingTimeChrono.SecondCount >= WaitingTimeChrono.startTimer)
        {
            MilliCount += Time.deltaTime * 10;
            MilliDisplay = MilliCount.ToString("F0");
            if (MilliCount <= 9)
            {
                MilliBox.GetComponent<Text>().text = "" + MilliDisplay;
            }

            if (MilliCount >= 10)
            {
                MilliBox.GetComponent<Text>().text = "0";
                MilliCount = 0;
                SecondCount += 1;
            }

            if (SecondCount <= 9)
            {
                SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
            }
            else
            {
                SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";
            }

            if (SecondCount >= 60)
            {
                SecondCount = 0;
                MinuteCount += 1;
            }

            if (MinuteCount <= 9)
            {
                MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
            }
            else
            {
                MinuteBox.GetComponent<Text>().text  = "" + MinuteCount + ":";
            }
        }
    }
}
