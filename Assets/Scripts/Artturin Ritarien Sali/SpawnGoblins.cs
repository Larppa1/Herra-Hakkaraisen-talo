using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class SpawnGoblins : MonoBehaviour {
        public GameObject obstacle;
        public float maxX;
        public float minX;
        public float maxY;
        public float minY;
        private float timer = 0;
        private int timeSimplified;
        public string oddOrEven;
        private bool isSpawned = false;
        private int randomSurprise;

        void Update() {
            timer += Time.deltaTime;
            timeSimplified = (int)timer;
            if (oddOrEven == "odd" && timeSimplified % 2 == 0 && timeSimplified % 4 != 0 && isSpawned == false) {
                float randomX = Random.Range(minX, maxX);
                float randomY = Random.Range(minY, maxY);
                Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
                isSpawned = true;
            }else if(oddOrEven == "even" && timeSimplified % 4 == 0 && isSpawned == false) {
                float randomX = Random.Range(minX, maxX);
                float randomY = Random.Range(minY, maxY);
                Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
                isSpawned = true;
            }

            if(oddOrEven == "odd" && timeSimplified % 4 == 0 && isSpawned == true) {
                randomSurprise = Random.Range(1, 10);
                if(randomSurprise == 1 || randomSurprise == 2) {
                    float randomX = Random.Range(minX, maxX);
                    float randomY = Random.Range(minY, maxY);
                    Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
                }else {
                    isSpawned = false;
                }
            }else if(oddOrEven == "even" && timeSimplified % 2 == 0 && timeSimplified % 4 != 0 && isSpawned == true) {
                randomSurprise = Random.Range(1, 10);
                if(randomSurprise == 1 || randomSurprise == 2) {
                    float randomX = Random.Range(minX, maxX);
                    float randomY = Random.Range(minY, maxY);
                    Instantiate(obstacle, transform.position = new Vector2(randomX, randomY), transform.rotation);
                }else {
                    isSpawned = false;
                }
            }
        }
    }
}