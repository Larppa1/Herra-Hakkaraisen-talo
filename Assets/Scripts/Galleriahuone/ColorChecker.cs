using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class ColorChecker : MonoBehaviour {
        public Button readyBtn;
        public GameObject topLeft;
        public GameObject topRight;
        public GameObject bottomLeft;
        public GameObject bottomRight;
        private Color topLeftColored;
        private Color topRightColored;
        private Color bottomLeftColored;
        private Color bottomRightColored;
        private int score = 0;

        void Start() {
            readyBtn.onClick.AddListener(CheckColors);
        }

        void CheckColors() {
                topLeftColored = topLeft.GetComponent<SpriteRenderer>().color;
                topRightColored = topRight.GetComponent<SpriteRenderer>().color;
                bottomLeftColored = bottomLeft.GetComponent<SpriteRenderer>().color;
                bottomRightColored = bottomRight.GetComponent<SpriteRenderer>().color;
                
                if(topLeftColored == Color.red) {
                    score++;
                }
                if(topRightColored == Color.yellow) {
                    score++;
                }
                if(bottomLeftColored == Color.green) {
                    score++;
                }
                if(bottomRightColored == Color.blue) {
                    score++;
                }
            Debug.Log(score);
        }
    }
}
