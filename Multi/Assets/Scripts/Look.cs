﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace Com.MoonDevs.MoonWalkers
{
    public class Look : MonoBehaviourPunCallbacks
    {
        public static bool cursorLocked = true;
        
        public Transform player;
        public Transform cams;

        public float xSensitivity;
        public float ySensitivity;
        public float maxAngleV;
		public float maxAngleH;

        private Quaternion camCenter;

        public static bool viewMove = true;
        
        void Start()
        {
            camCenter = cams.localRotation; //set rotation origin for cameras to camCenter

        }

        void Update()
        {
            if (!photonView.IsMine) return;

            if (viewMove)
            {
                SetY();
                SetX();
            }

            UpdateCursorLock();
        }

        void SetY()
        {
            float t_input = Input.GetAxis("Mouse Y") * ySensitivity * Time.deltaTime;
            Quaternion t_adj = Quaternion.AngleAxis(t_input, -Vector3.right);
            Quaternion t_delta = cams.localRotation * t_adj;

            if (Quaternion.Angle(camCenter,t_delta)< maxAngleV)
            {
                cams.localRotation = t_delta;
            }
        }
        
        void SetX()
        {
            float t_input = Input.GetAxis("Mouse X") * xSensitivity * Time.deltaTime;
            Quaternion t_adj = Quaternion.AngleAxis(t_input, Vector3.up);
            Quaternion t_delta = player.localRotation * t_adj;
			
			if(Quaternion.Angle(camCenter,t_delta)< maxAngleH)
			{
				cams.localRotation = t_delta;
			}
        }

        void UpdateCursorLock()
        {
            if (cursorLocked)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    cursorLocked = false;
                }
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    cursorLocked = true;
                }
            }
        }
    }
}
