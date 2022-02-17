using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class SpawnGoblins : MonoBehaviour {
        public GameObject obstacle;
        public float minX, maxX, minY, maxY, timer = 0;
        public string oddOrEven;
        private int timeSimplified, randomSurprise;
        //private float time = 0;
        private bool isFirstTime = true;

        void OnEnable() {
            this.gameObject.SetActive(false);

            if(GoblinProperties.amountSpawned == WaveSystem.firstWaveEnemyCount || GoblinProperties.amountSpawned == WaveSystem.secondWaveEnemyCount) {
                Invoke("Spawn", 15);
            }else if(isFirstTime && oddOrEven == "odd") {
                Invoke("Spawn", 0);
            }else if(isFirstTime && oddOrEven == "even") {
                Invoke("Spawn", 2);
            }else {
                Invoke("Spawn", 4);
            }
            isFirstTime = false;
        }

        private void Spawn() {
            if((GoblinProperties.amountSpawned == WaveSystem.firstWaveEnemyCount || GoblinProperties.amountSpawned == WaveSystem.secondWaveEnemyCount)) return;

            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
            GoblinProperties.amountSpawned++;
            this.gameObject.SetActive(true);
            
            SpawnRandom();
        }

        private void SpawnRandom() {
            randomSurprise = Random.Range(1, 10);

            if(randomSurprise == 1 || randomSurprise == 2) {
                float randomX = Random.Range(minX, maxX);
                float randomY = Random.Range(minY, maxY);
                GoblinProperties.extras++;
                Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
            }
        }
    }
}