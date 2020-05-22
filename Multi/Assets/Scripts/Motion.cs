using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun; 

namespace Com.MoonDevs.MoonWalkers
{
    public class Motion : MonoBehaviourPunCallbacks
    {
        public float speed;
        public float sprintModifier;
        public float jumpForce;
        public Camera normalCam;
        public GameObject cameraParent;


        private Rigidbody rig;

        public float forwardForce = 2000f;
        public float sidewaysForce = 500f;
        public float maxspeed = 2000f;
        public float turnSpeed = 50f;

        private float baseFOV;
        private float sprintFOVModifier = 1.5f;
        
        private void Start()
        {
            cameraParent.SetActive(photonView.IsMine);
            
            baseFOV = normalCam.fieldOfView;

            if (Camera.main)
            {
                Camera.main.enabled = false;
            }
            
            rig = GetComponent<Rigidbody>();
        }

        private void Update()
		{
            if (!photonView.IsMine) return;

            //Axles
            float t_hmove = Input.GetAxisRaw("Horizontal");
            float t_vmove = Input.GetAxisRaw("Vertical");
            
            
            //Controls
            bool sprint = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
            bool jump = Input.GetKey(KeyCode.Space);


            //States
            bool isJumping = jump;
            bool isSprinting = sprint && t_vmove > 0 ;

            //Jumping
            if (isJumping)
            {
                rig.AddForce(Vector3.up * jumpForce);
            }
        }

        void FixedUpdate()
        {
            if (!photonView.IsMine) return;

            if (rig.velocity.magnitude <maxspeed)
            {
                rig.AddForce(0, 0, forwardForce * Time.deltaTime);
            }

            if (Input.GetKey("d"))
            {
                rig.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
                //transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            }

            if (Input.GetKey("a"))
            {
                rig.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
                //transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            }

            if (Input.GetKey("s"))
            {
                rig.AddForce(0, 0, -(forwardForce / 2) * Time.deltaTime);
            }

            //Axles
            float t_hmove = Input.GetAxisRaw("Horizontal");
            float t_vmove = Input.GetAxisRaw("Vertical");
            
            
            //Controls
            bool sprint = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
            bool jump = Input.GetKey(KeyCode.Space);

            //States
            bool isJumping = jump;
            bool isSprinting = sprint && t_vmove > 0 ;

            //Jumping
            if (isJumping)
            {
                rig.AddForce(Vector3.up * jumpForce);
            }

            //Movement
            

            float t_adjustedSpeed = speed;
            if (isSprinting)
            {
                t_adjustedSpeed *= sprintModifier;
            }
            

            
            
            
            //Field of View
            if (isSprinting)
            {
                normalCam.fieldOfView = Mathf.Lerp(normalCam.fieldOfView,baseFOV * sprintFOVModifier,Time.deltaTime * 8f);
            }
            else
            {
                normalCam.fieldOfView = Mathf.Lerp(normalCam.fieldOfView,baseFOV,Time.deltaTime * 8f);
            }
            
        }
    }
}
