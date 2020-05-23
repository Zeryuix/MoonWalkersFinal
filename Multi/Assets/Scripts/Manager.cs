﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace Com.MoonDevs.MoonWalkers
{

    public class Manager : MonoBehaviour
    {
        public string player_prefab;
        public Transform spawn_point;
        public static GameObject instantiatedPlayer;

        private void Start()
		{
            Spawn();
		}

        public void Spawn()
		{
            instantiatedPlayer = PhotonNetwork.Instantiate(player_prefab, spawn_point.position, spawn_point.rotation);
		}
    }
}
