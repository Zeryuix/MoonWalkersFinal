using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class TestDeployAsteroid : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject firstSpawn;
    public float respawnTime = 0.2f;
    private Vector3 screenBounds;
    public int dist;
    public static Vector3 spawn;

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
        spawn = firstSpawn.transform.position;
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
        a.transform.position = new Vector3(posX, posY, posZ);
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
