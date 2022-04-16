using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class SpawnGoblins : MonoBehaviour {
        [SerializeField] Text timerText;
        public GameObject obstacle, gameOverPanel;
        public float minX, maxX, minY, maxY, timer = 0;
        public string oddOrEven;
        private int timeSimplified, randomSurprise;
        private bool isFirstTime = true, isOnbreak = false;

        void OnEnable() {
            if(GoblinProperties.amountSpawned == WaveSystem.thirdWaveEnemyCount) GameOver();
            this.gameObject.SetActive(false);
            if((GoblinProperties.amountSpawned == WaveSystem.firstWaveEnemyCount || GoblinProperties.amountSpawned == WaveSystem.secondWaveEnemyCount)
            || GoblinProperties.amountSpawned == WaveSystem.firstWaveEnemyCount-1 || GoblinProperties.amountSpawned == WaveSystem.secondWaveEnemyCount-1) {
                if(oddOrEven == "odd") timerText.gameObject.SetActive(true);
                isOnbreak = true;
                Invoke("Spawn", 20);
            }else if(isFirstTime && oddOrEven == "odd") {
                Invoke("Spawn", 0);
            }else if(isFirstTime && oddOrEven == "even") {
                Invoke("Spawn", 3);
            }else {
                Invoke("Spawn", 6);
            }
            isFirstTime = false;
        }

        private void Spawn() {
            if((GoblinProperties.amountSpawned == WaveSystem.firstWaveEnemyCount || GoblinProperties.amountSpawned == WaveSystem.secondWaveEnemyCount) && !isOnbreak) return;

            isOnbreak = false;
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

        private void GameOver() {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}