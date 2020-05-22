using System.Collections;
using System.Collections.Generic;
using System;
using System.Numerics;
using System.Timers;
using UnityEngine;
using Object = System.Object;
using Random = System.Random;
using Vector3 = UnityEngine.Vector3;

public class MeteoriteFall : MonoBehaviour
{
    private static Timer aTimer;
    public GameObject Sol, Fusee;
    public static int xpos, ypos, zpos;

    private void Start()
    {
        aTimer = new Timer();
        aTimer.Interval = 2;
    }

    void Update()
    {
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    public static int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }

    private static void OnTimedEvent(Object Source, ElapsedEventArgs e)
    {
        int xl = 535;
        xpos = 0;
        ypos = 0;
        zpos = 0;
        
        GameObject tmp = new GameObject();
        tmp.transform.position = new Vector3(RandomNumber(xpos, xl), ypos, RandomNumber(zpos + 5, zpos + 12));
    }
}
