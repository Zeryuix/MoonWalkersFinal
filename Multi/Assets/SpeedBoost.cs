using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Motion = Com.MoonDevs.MoonWalkers.Motion;

public class SpeedBoost : MonoBehaviour
{
    public static float count;
    public static bool shield;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player" || other.gameObject.name == "Player(Clone)" || other.gameObject.name == "PlayerSolo" || other.gameObject.name == "PlayerSolo(Clone)")
        {
            if (ManagerSoloGame.isSolo)
            {
                Destroy(this.gameObject);
                if (MotionSolo.mult == MotionSolo.maxMult)
                {
                    MotionSolo.maxMult += 0.05f;
                }
                else
                {
                    MotionSolo.mult += 0.1f;
                    if (MotionSolo.mult > MotionSolo.maxMult)
                    {
                        MotionSolo.mult = MotionSolo.maxMult;
                    }
                }
            }
            else
            {
                Destroy(this.gameObject);
                if (Motion.mult == Motion.maxMult)
                {
                    Motion.maxMult += 0.05f;
                }
                else
                {
                    Motion.mult += 0.1f;
                    if (Motion.mult > Motion.maxMult)
                    {
                        Motion.mult = Motion.maxMult;
                    }
                }
            }
        }
    }
}
