using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class Countdown : MonoBehaviour {
        public Text countdowntext;
        public GameObject topLeft, topRight, bottomLeft, bottomRight, readyButton;
        private SpriteRenderer topLeftRenderer, topRightRenderer, bottomLeftRenderer, bottomRightRenderer;
        public static float coloringTimer = 0;
        void Update() {
            if(GalleryDifficulty.countSize>0){
                GalleryDifficulty.countSize -= Time.deltaTime;
                countdowntext.text = ((int)GalleryDifficulty.countSize).ToString();
            }else if ((int)GalleryDifficulty.countSize == 0) {
                topLeft.GetComponent<SpriteRenderer>().color = Color.white;
                topRight.GetComponent<SpriteRenderer>().color = Color.white;
                bottomLeft.GetComponent<SpriteRenderer>().color = Color.white;
                bottomRight.GetComponent<SpriteRenderer>().color = Color.white;

                ColorChecker.counted = true;
                GalleryDifficulty.countSize--;
                readyButton.SetActive(true);

            }else if((int)GalleryDifficulty.countSize == -1) {
                coloringTimer += Time.deltaTime;
            }
        }
    }
}