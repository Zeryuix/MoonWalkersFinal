using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class LauncherSolo : MonoBehaviourPunCallbacks
{
    public static bool hasJoined = false;
	    
    public void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        Connect();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("CONNECTED!");
        Join();
        hasJoined = true;
        base.OnConnectedToMaster();
    }

    public override void OnJoinedRoom()
    {
        StartGame();

        base.OnJoinedRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Create();

        base.OnJoinRandomFailed(returnCode, message);
    }

    public void Connect()
    {
        Debug.Log("Trying to Connect...");
        PhotonNetwork.GameVersion = "0.0.0";
        PhotonNetwork.ConnectUsingSettings();
    }

    public void Join()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public void Create()
    {
        PhotonNetwork.CreateRoom("");
    }

    public void StartGame()
    {
        if(PhotonNetwork.CurrentRoom.PlayerCount==1)
        {
            PhotonNetwork.LoadLevel(4);
        }
    }
}
