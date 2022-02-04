using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class Countdown : MonoBehaviour {
        public Text countdowntext;
        public GameObject topLeft, topRight, bottomLeft, bottomRight;
        private SpriteRenderer topLeftRenderer, topRightRenderer, bottomLeftRenderer, bottomRightRenderer;
        private float count = 10;

        void Update() {
            if(count>0){
                count -= Time.deltaTime;
                countdowntext.text = ((int)count).ToString();
            }else if ((int)count == 0) {
                topLeft.GetComponent<SpriteRenderer>().color = Color.white;
                topRight.GetComponent<SpriteRenderer>().color = Color.white;
                bottomLeft.GetComponent<SpriteRenderer>().color = Color.white;
                bottomRight.GetComponent<SpriteRenderer>().color = Color.white;
                count--;
            }
        }
    }
}