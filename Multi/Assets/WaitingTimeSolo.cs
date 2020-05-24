using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitingTimeSolo : MonoBehaviour
{
    public static float MilliCount;
    public static int SecondCount;

    public GameObject Chrono;
    public GameObject SecondBox;
    public GameObject Timer;
    
    public static int startTimer = 5;
    public static bool DecountDis = true;
    public static bool TimerDis = false;
    
    // Update is called once per frame
    void Update()
    {
        if (DecountDis)
        {
            MilliCount += Time.deltaTime * 10;
            if (MilliCount >= 10)
            {
                MilliCount = 0;
                SecondCount += 1;
            }
            
            if (SecondCount >= (startTimer - 9))
            {
                SecondBox.GetComponent<Text>().text = "0" + (startTimer - SecondCount);
            }
            else
            {
                SecondBox.GetComponent<Text>().text = "" + (startTimer - SecondCount);
            }
        }

        if (SecondCount >= startTimer)
        {
            Chrono.SetActive(false);
            Timer.SetActive(true);
            TimerDis = true;
            DecountDis = false;
        }
    }
}
