using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class ScoreManager : MonoBehaviour {
        public Text scoreText;
        private float scoreFloat;
        public static int score;

        void Update() {
            if(GameObject.FindGameObjectWithTag("Player") != null) {
                for(int i = 0; i < 5; i++) {
                    scoreFloat += 1 * Time.deltaTime;
                    score = (int)scoreFloat;
                    scoreText.text = (score).ToString();
                }
            }else{
                scoreText.enabled = false;
            }
            if(score > PlayerPrefs.GetInt("highscore")) {
                PlayerPrefs.SetInt("highscore", score);
            }
        }
    }
}