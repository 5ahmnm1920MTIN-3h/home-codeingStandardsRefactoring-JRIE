using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public static ObstacleSpawner instance;

    public GameObject[] obstacles;

    public bool gameOver = false;

    public float minSpawnTime, maxSpawnTime;

    // Sets instance on Awake
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Starts the Spawn Coroutine
    void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        float waitTime = 1f;

        yield return new WaitForSeconds (waitTime);

        while (!gameOver)
        {
            SpawnObstacle();
            
            waitTime = Random.Range(minSpawnTime,maxSpawnTime);

            yield return new WaitForSeconds(waitTime);
        }
    }
    //Spawns Obstacles randomly with space limitations
    void SpawnObstacle()
    {
        int random = Random.Range(0,obstacles.Length);

        Instantiate(obstacles[random],transform.position,Quaternion.identity);
    }
}
