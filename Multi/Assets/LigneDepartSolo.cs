using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigneDepartSolo : MonoBehaviour
{
    public GameObject LigneDeDepart;
    
    // Update is called once per frame
    void Update()
    {
        if (WaitingTimeSolo.SecondCount >= WaitingTimeSolo.startTimer)
        {
            Collider.Destroy(LigneDeDepart);
        }
    }
}
