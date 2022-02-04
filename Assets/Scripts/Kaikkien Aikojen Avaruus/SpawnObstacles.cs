using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class SpawnObstacles : MonoBehaviour {
        public GameObject meteor1, meteor2, meteor3, coin, coin2, coin3;
        public float minY, maxY, timeBetweenSpawn, spawnTime, randomY;
        private bool isSpawnTimeUpdated;

        void Update() {
            if (Time.time > spawnTime) {
                randomY = Random.Range(minY, maxY);
                int randomMeteor = Random.Range(1, 3);
                switch(randomMeteor) {
                    case 1: Instantiate(meteor1, transform.position + new Vector3(0, randomY, 0), transform.rotation);
                            MeteorProperties.meteorPosY = meteor1.transform.position.y; break;
                    case 2: Instantiate(meteor2, transform.position + new Vector3(0, randomY, 0), transform.rotation);
                            MeteorProperties.meteorPosY = meteor2.transform.position.y; break;
                    case 3: Instantiate(meteor3, transform.position + new Vector3(0, randomY, 0), transform.rotation);
                            MeteorProperties.meteorPosY = meteor3.transform.position.y; break;
                }
                spawnTime = Time.time + (float)timeBetweenSpawn;

                if(MeteorProperties.meteorCount % 5 == 0) {
                    SpawnCoin();
                }
            }

            if(ScoreManager.score == 0) {

            }else if(ScoreManager.score % 100 == 0 && isSpawnTimeUpdated == false && timeBetweenSpawn >= 1) {
                timeBetweenSpawn -= (float)0.05;
                isSpawnTimeUpdated = true;
            }else if(ScoreManager.score % 100 != 0) {
                isSpawnTimeUpdated = false;
            }
        }

        void SpawnCoin() {
            randomY = Random.Range(minY, maxY);
            
            if(MeteorProperties.coinCount == 0) {
                
            }else if(MeteorProperties.coinCount % 10 == 0) {
                Instantiate(coin3, transform.position + new Vector3(5, randomY, 0), transform.rotation);
            }else if(MeteorProperties.coinCount % 5 == 0) {
                Instantiate(coin2, transform.position + new Vector3(10, randomY, 0), transform.rotation);
            }else {
                Instantiate(coin, transform.position + new Vector3(15, randomY, 0), transform.rotation);
            }

            MeteorProperties.coinCount++;
        }
    }
}