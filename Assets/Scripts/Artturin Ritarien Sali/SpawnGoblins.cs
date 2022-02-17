using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class SpawnGoblins : MonoBehaviour {
        public GameObject obstacle;
        public float minX, maxX, minY, maxY, timer = 0;
        public string oddOrEven;
        private int timeSimplified, randomSurprise;
        private bool isSpawned = false;
        private float time = 0;

        void Update() {
            if(GoblinProperties.amountSpawned == WaveSystem.thirdWaveEnemyCount){
                this.gameObject.SetActive(false);
            }
            timer += Time.deltaTime;
            timeSimplified = (int)timer;
            if((GoblinProperties.amountSpawned == WaveSystem.firstWaveEnemyCount || GoblinProperties.amountSpawned == WaveSystem.secondWaveEnemyCount) && time < 15) {
                time += Time.deltaTime;
            }else if (oddOrEven == "odd" && timeSimplified % 2 == 0 && timeSimplified % 4 != 0 && isSpawned == false) {
                float randomX = Random.Range(minX, maxX);
                float randomY = Random.Range(minY, maxY);
                Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
                isSpawned = true;
                GoblinProperties.amountSpawned++;
            }else if(oddOrEven == "even" && timeSimplified % 4 == 0 && isSpawned == false) {
                float randomX = Random.Range(minX, maxX);
                float randomY = Random.Range(minY, maxY);
                Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
                isSpawned = true;
                GoblinProperties.amountSpawned++;
            }else if(time >= 15) {
                time = 0;
            }

            if(oddOrEven == "odd" && timeSimplified % 4 == 0 && isSpawned == true) {
                randomSurprise = Random.Range(1, 10);
                if(randomSurprise == 1 || randomSurprise == 2) {
                    float randomX = Random.Range(minX, maxX);
                    float randomY = Random.Range(minY, maxY);
                    GoblinProperties.extras++;
                    Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
                }else {
                    isSpawned = false;
                }
            }else if(oddOrEven == "even" && timeSimplified % 2 == 0 && timeSimplified % 4 != 0 && isSpawned == true) {
                randomSurprise = Random.Range(1, 10);
                if(randomSurprise == 1 || randomSurprise == 2) {
                    float randomX = Random.Range(minX, maxX);
                    float randomY = Random.Range(minY, maxY);
                    GoblinProperties.extras++;
                    Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
                }else {
                    isSpawned = false;
                }
            }
        }
    }
}