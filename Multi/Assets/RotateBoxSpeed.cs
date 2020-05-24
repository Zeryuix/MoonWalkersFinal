using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoxSpeed : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(-1,0.5f,1));
    }
}
