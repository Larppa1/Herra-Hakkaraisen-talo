using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class Countdown : MonoBehaviour {
        public Text countdowntext;
        public GameObject readyButton, easyReal, normalReal, hardReal;
        public GameObject[] easyPictures = new GameObject[5];
        public GameObject[] normalPictures = new GameObject[5];
        public GameObject[] hardPictures = new GameObject[5];
        public static float coloringTimer = 0;
        void Update() {
            if(GalleryDifficulty.countSize>0){
                GalleryDifficulty.countSize -= Time.deltaTime;
                countdowntext.text = ((int)GalleryDifficulty.countSize).ToString();
            }else if ((int)GalleryDifficulty.countSize == 0) {
                switch(GalleryDifficulty.difficulty) {
                    case "easy":
                        for(int i = 0; i < easyPictures.Length; i++) {
                            easyPictures[i].SetActive(true);
                            easyReal.SetActive(false);
                        }
                        break;
                    case "normal":
                        for(int i = 0; i < normalPictures.Length; i++) {
                            normalPictures[i].SetActive(true);
                            normalReal.SetActive(false);
                        }
                        break;
                    case "hard":
                        for(int i = 0; i < hardPictures.Length; i++) {
                            hardPictures[i].SetActive(true);
                            hardReal.SetActive(false);
                        }
                        break;
                }

                ColorChecker.counted = true;
                GalleryDifficulty.countSize--;
                readyButton.SetActive(true);
                countdowntext.gameObject.SetActive(false);

            }else if((int)GalleryDifficulty.countSize == -1) {
                coloringTimer += Time.deltaTime;
            }
        }
    }
}