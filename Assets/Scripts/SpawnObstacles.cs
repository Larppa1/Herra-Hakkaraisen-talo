using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class SpawnObstacles : MonoBehaviour {
        public GameObject obstacle;
        public GameObject coin;
        public GameObject coin2;
        public GameObject coin3;
        public float maxX;
        public float minX;
        public float maxY;
        public float minY;
        public float timeBetweenSpawn;
        private float spawnTime;

        void Update() {
            if (Time.time > spawnTime) {
                float randomY = Random.Range(minY, maxY);
                Instantiate(obstacle, transform.position = new Vector2(10, randomY), transform.rotation);
                spawnTime = Time.time + timeBetweenSpawn;

                MeteorProperties.meteorPosX = obstacle.transform.position.x;
                MeteorProperties.meteorPosY = obstacle.transform.position.y;

                if(MeteorProperties.meteorCount % 5 == 0) {
                    SpawnCoin();
                }
            }
        }

        void SpawnCoin() {
            float randomY = 0;

            do {
                randomY = Random.Range(minY, maxY);
            }while(randomY == MeteorProperties.meteorPosY);

            if(MeteorProperties.coinCount == 0) {
                
            }else if(MeteorProperties.coinCount % 10 == 0) {
                Instantiate(coin3, transform.position = new Vector2(10, randomY), transform.rotation);
            }else if(MeteorProperties.coinCount % 5 == 0) {
                Instantiate(coin2, transform.position = new Vector2(10, randomY), transform.rotation);
            }else {
                Instantiate(coin, transform.position = new Vector2(10, randomY), transform.rotation);
            }

            MeteorProperties.coinCount++;
        }
    }
}