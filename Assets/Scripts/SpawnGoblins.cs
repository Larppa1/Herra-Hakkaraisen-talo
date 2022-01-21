using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021{
public class SpawnGoblins : MonoBehaviour
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
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }
}
}