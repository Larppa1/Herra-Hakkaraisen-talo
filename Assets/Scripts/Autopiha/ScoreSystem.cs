using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class ScoreSystem : MonoBehaviour {
        public static int score;
        public Transform player;
        public Text scoreText;

        void Update() {
            if((int)player.position.x > 0 && (int) player.position.x > score) {
                score = (int)player.position.x;
                scoreText.text = ((int)score).ToString();
            }
        }
    }
}
