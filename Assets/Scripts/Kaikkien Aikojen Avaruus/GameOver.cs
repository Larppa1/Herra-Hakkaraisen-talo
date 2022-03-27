using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class GameOver : MonoBehaviour {
        public GameObject gameOverPanel, coinBar;
        public Button menuBtn;
        public Text lastScore, highScore;
        private bool isScoreUpdated = false, isGameLost = false;

        void Start() {
            Time.timeScale = 1;
            isGameLost = false;
        }

        void Update() {
            if(GameObject.FindGameObjectWithTag("Player") == null && !isGameLost) {
                Time.timeScale = 0;
                MeteorProperties.coinCount = 0;
                MeteorProperties.meteorCount = 0;
                gameOverPanel.SetActive(true);
                coinBar.SetActive(false);
                menuBtn.gameObject.SetActive(false);
                isGameLost = true;
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
            isGameLost = false;
            Time.timeScale = 1;
            isScoreUpdated = false;
            CoinManager.amount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}