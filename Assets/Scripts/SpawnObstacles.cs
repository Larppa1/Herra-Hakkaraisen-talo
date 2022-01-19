using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    void Update()
    {
        if (Time.time > spawnTime)
        {
            float randomY = Random.Range(minY, maxY);
            Instantiate(obstacle, transform.position = new Vector2(10, randomY), transform.rotation);
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }
}
