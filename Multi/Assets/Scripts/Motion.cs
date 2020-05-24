using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun; 

namespace Com.MoonDevs.MoonWalkers
{
    public class Motion : MonoBehaviourPunCallbacks
    {
        public static float speed = 1000;
        public float sprintModifier;
        public float jumpForce;
        public Camera normalCam;
        public GameObject cameraParent;


        private Rigidbody rig;

        public static float forwardForce = 1000f;
        public float sidewaysForce = 500f;
        public float maxspeed = 2000f;
        public float turnSpeed = 50f;
        public static float mult = 0.01f;
        public static float maxMult = 1;

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
            if (mult < maxMult)
            {
                mult += 0.00002f;
            }

            if (CollisionFusee.crashed)
            {
                mult = 0.01f;
                rig.velocity = Vector3.zero;
                rig.angularVelocity = Vector3.zero;
                rig.Sleep();
                CollisionFusee.crashed = false;
            }
            
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
                rig.AddForce(0, 0, forwardForce * mult);
            }

            if (Input.GetKey("d"))
            {
                rig.AddForce(sidewaysForce * mult, 0, 0);
                //transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            }

            if (Input.GetKey("a"))
            {
                rig.AddForce(-sidewaysForce * mult, 0, 0);
                //transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            }

            if (Input.GetKey("s"))
            {
                rig.AddForce(0, 0, -(forwardForce / 2) * mult);
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
                normalCam.fieldOfView = Mathf.Lerp(normalCam.fieldOfView,baseFOV * sprintFOVModifier,mult * 8f);
            }
            else
            {
                normalCam.fieldOfView = Mathf.Lerp(normalCam.fieldOfView,baseFOV,mult * 8f);
            }
            
        }
    }
}
