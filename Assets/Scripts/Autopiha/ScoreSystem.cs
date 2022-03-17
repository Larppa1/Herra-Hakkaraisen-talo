using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class ScoreSystem : MonoBehaviour {
        public static int score;
        public Transform player;
        public Text scoreText;
        private int offset = 7;

        void Update() {
            if((int)player.position.x > offset && (int) player.position.x - offset > score) {
                score = (int)player.position.x - offset;
                scoreText.text = ((int)score).ToString();
            }
        }
    }
}
