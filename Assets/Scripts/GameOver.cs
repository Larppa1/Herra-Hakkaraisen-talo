using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace TIKO4A2021 {
    public class GameOver : MonoBehaviour {
        public GameObject gameOverPanel;
        private bool isPaused = false;

        void Update() {
            if(GameObject.FindGameObjectWithTag("Player") == null) {
                isPaused = true;
                MeteorProperties.coinCount = 0;
                MeteorProperties.meteorCount = 0;
                CoinCount.amount = 0;
                gameOverPanel.SetActive(true);
            }

            if(isPaused) {
                Time.timeScale = 0;
            }else {
                Time.timeScale = 1;
            }
        }

        public void Restart() {
            isPaused = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}