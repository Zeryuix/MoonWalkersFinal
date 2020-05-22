using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigneDepart : MonoBehaviour
{
    public GameObject LigneDeDepart;
    
    // Update is called once per frame
    void Update()
    {
        if (WaitingTimeChrono.SecondCount >= WaitingTimeChrono.startTimer)
        {
            Collider.Destroy(LigneDeDepart);
        }
    }
}
