using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class ScoreManager : MonoBehaviour {
        public Text scoreText;
        private float score;

        void Update() {
            if(GameObject.FindGameObjectWithTag("Player") != null) {
                for(int i = 0; i < 5; i++) {
                    score += 1 * Time.deltaTime;
                    scoreText.text = ((int)score).ToString();
                }
            }else{
                scoreText.enabled = false;
            }
        }
    }
}