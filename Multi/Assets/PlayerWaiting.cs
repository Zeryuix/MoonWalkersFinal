using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWaiting : MonoBehaviour
{
    public static int nbPlayers = 4;
    private int countdot = 0;
    public static float milliCounter;

    public GameObject nbPlayersDisplay;
    public GameObject waitingMenu;
    public GameObject decount;
    public GameObject threeDots;

    public static bool WaitingPlayersDis = true;
    
    // Update is called once per frame
    void Update()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount < 4)
        {
            milliCounter += Time.deltaTime * 10;
            nbPlayersDisplay.GetComponent<Text>().text = "" + (nbPlayers - PhotonNetwork.CurrentRoom.PlayerCount);
            if (milliCounter >= 10)
            {
                switch (countdot)
                {
                    case 0:
                        threeDots.GetComponent<Text>().text = "";
                        countdot++;
                        break;
                    case 1:
                        threeDots.GetComponent<Text>().text = ".";
                        countdot++;
                        break;
                    case 2:
                        threeDots.GetComponent<Text>().text = "..";
                        countdot++;
                        break;
                    case 3:
                        threeDots.GetComponent<Text>().text = "...";
                        countdot = 0;
                        break;
                }
                
                milliCounter = 0;
            }
        }
        else
        {
            WaitingPlayersDis = false;
            waitingMenu.SetActive(false);
            decount.SetActive(true);
        }
    }
}
