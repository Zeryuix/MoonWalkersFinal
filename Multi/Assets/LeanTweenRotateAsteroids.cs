using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class LeanTweenRotateAsteroids : MonoBehaviour
{
    public int rotationMax;
    public int rotationMin;

    public float rotation()
    {
        Random random = new Random();
        return random.Next(rotationMin / 10, rotationMax / 10);
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, rotation()));
    }
}
