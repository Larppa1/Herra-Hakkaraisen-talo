using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class ScoreSystem : MonoBehaviour {
        private int score;
        public Transform player;
        public Text scoreText;
        public static float offset = 0;

        void Update() {
            if((int)player.position.x == score + 1 && player.position.x > 0) {
                score++;
                scoreText.text = ((int)score).ToString();
            }
        }
    }
}
