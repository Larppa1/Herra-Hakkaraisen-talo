using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class GameOver : MonoBehaviour {
        public GameObject gameOverPanel, coinBar;
        public Text lastScore, highScore;
        public bool isPaused = false, isScoreUpdated = false;

        void Update() {
            if(GameObject.FindGameObjectWithTag("Player") == null) {
                isPaused = true;
                MeteorProperties.coinCount = 0;
                MeteorProperties.meteorCount = 0;
                gameOverPanel.SetActive(true);
                coinBar.SetActive(false);
            }

            if(isPaused) {
                Time.timeScale = 0;
            }else {
                Time.timeScale = 1;
            }

            if(gameOverPanel.activeSelf && isScoreUpdated == false) {
                if(ScoreManager.score > PlayerPrefs.GetInt("highscore")) {
                    PlayerPrefs.SetInt("highscore", ScoreManager.score);
                }
                lastScore.text = "Pisteet: " + (ScoreManager.score).ToString();
                highScore.text = "Paras tulos: " + (PlayerPrefs.GetInt("highscore")).ToString();
                PlayerPrefs.SetInt("coinCount", PlayerPrefs.GetInt("coinCount") + CoinManager.amount);
                isScoreUpdated = true;
            }
        }

        public void Restart() {
            isPaused = false;
            isScoreUpdated = false;
            CoinManager.amount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}