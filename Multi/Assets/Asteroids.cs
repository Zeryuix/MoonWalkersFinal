using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public static float speed = 200;
    private Rigidbody rb;
    private Vector3 screenBounds;
    public GameObject DepSpawn1, DepSpawn2, DepSpawn3, DepSpawn4, DepSpawn5, DepSpawn6;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -speed);
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < screenBounds.z) 
        {
                Destroy(this.gameObject); 
        }
    }
}
