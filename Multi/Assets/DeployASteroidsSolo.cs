using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployASteroidsSolo : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject firstSpawn, secondSpawn, thirdSpawn, fourthSpawn, fifthSpawn, sixthSpawn,lastSpawn;
    public float respawnTime = 0.2f;
    private Vector3 screenBounds;
    public int dist;
    public static Vector3 spawn, spawn1, spawn2, spawn3, spawn4, spawn5, spawn6;
    public static bool areConnected = false;
    public static int count = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }

    private void spawnEnnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        GameObject a1 = Instantiate(asteroidPrefab) as GameObject;
        GameObject a2 = Instantiate(asteroidPrefab) as GameObject;
        GameObject a3 = Instantiate(asteroidPrefab) as GameObject;
        GameObject a4 = Instantiate(asteroidPrefab) as GameObject;
        GameObject a5 = Instantiate(asteroidPrefab) as GameObject;
        GameObject a6 = Instantiate(asteroidPrefab) as GameObject;
        spawn = firstSpawn.transform.position;
        spawn1 = secondSpawn.transform.position;
        spawn2 = thirdSpawn.transform.position;
        spawn3 = fourthSpawn.transform.position;
        spawn4 = fifthSpawn.transform.position;
        spawn5 = sixthSpawn.transform.position;
        spawn6 = lastSpawn.transform.position;
        System.Random random = new System.Random();
        int randX = random.Next(-dist, dist);
        int randY = random.Next(-dist, dist);
        float posX = spawn.x + randX;
        float posY = spawn.y + randY;
        float posZ = spawn.z;
        if (posX < -45)
            posX = -45;
        if (posX > 49)
            posX = 49;
        if (posY < 10)
            posY = 10;
        if (posY > 85)
            posY = 85;
        float posX1 = spawn1.x + randX;
        float posY1 = spawn1.y + randY;
        float posZ1 = spawn1.z;
        if (posX1 < -45)
            posX1 = -45;
        if (posX1 > 49)
            posX1 = 49;
        if (posY1 < 10)
            posY1 = 10;
        if (posY1 > 85)
            posY1 = 85;
        float posX2 = spawn2.x + randX;
        float posY2 = spawn2.y + randY;
        float posZ2 = spawn2.z;
        if (posX2 < -45)
            posX2 = -45;
        if (posX2 > 49)
            posX2 = 49;
        if (posY2 < 10)
            posY2 = 10;
        if (posY2 > 85)
            posY2 = 85;
        float posX3 = spawn3.x + randX;
        float posY3 = spawn3.y + randY;
        float posZ3 = spawn3.z;
        if (posX3 < -45)
            posX3 = -45;
        if (posX3 > 49)
            posX3 = 49;
        if (posY3 < 10)
            posY3 = 10;
        if (posY3 > 85)
            posY3 = 85;
        float posX4 = spawn4.x + randX;
        float posY4 = spawn4.y + randY;
        float posZ4 = spawn4.z;
        if (posX4 < -45)
            posX4 = -45;
        if (posX4 > 49)
            posX4 = 49;
        if (posY4 < 10)
            posY4 = 10;
        if (posY4 > 85)
            posY4 = 85;
        float posX5 = spawn5.x + randX;
        float posY5 = spawn5.y + randY;
        float posZ5 = spawn5.z;
        if (posX5 < -45)
            posX5 = -45;
        if (posX5 > 49)
            posX5 = 49;
        if (posY5 < 10)
            posY5 = 10;
        if (posY5 > 85)
            posY5 = 85;
        float posX6 = spawn6.x + randX;
        float posY6 = spawn6.y + randY;
        float posZ6 = spawn6.z;
        if (posX6 < -45)
            posX6 = -45;
        if (posX6 > 49)
            posX6 = 49;
        if (posY6 < 10)
            posY6 = 10;
        if (posY6 > 85)
            posY6 = 85;
        a.transform.position = new Vector3(posX, posY, posZ);
        a1.transform.position = new Vector3(posX1, posY1, posZ1);
        a2.transform.position = new Vector3(posX2, posY2, posZ2);
        a3.transform.position = new Vector3(posX3, posY3, posZ3);
        a4.transform.position = new Vector3(posX4, posY4, posZ4);
        a5.transform.position = new Vector3(posX5, posY5, posZ5);
        a6.transform.position = new Vector3(posX6, posY6, posZ6);
    }

    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnnemy();
        }
    }
}
