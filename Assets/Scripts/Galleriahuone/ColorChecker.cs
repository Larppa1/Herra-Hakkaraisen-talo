using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class ColorChecker : MonoBehaviour {
        public Button readyBtn;
        public GameObject colorPalette, menuBtn, gameOverPanel;
        public static int score = 0;
        public static bool counted = false;
        public GameObject[] easyPictures = new GameObject[5];
        public GameObject[] normalPictures = new GameObject[5];
        public GameObject[] hardPictures = new GameObject[5];
        public Color[] easyColors = new Color[5];
        public Color[] normalColors = new Color[5];
        public Color[] hardColors = new Color[5];
        private Color[] realColors = new Color[5];

        public void CheckColors() {
            switch(GalleryDifficulty.difficulty) {
                case "easy":
                    for(int i = 0; i < easyPictures.Length; i++) {
                        realColors[i] = easyPictures[i].GetComponent<SpriteRenderer>().color;
                        if(easyColors[i] == realColors[i]) {
                            score++;
                        }
                        easyPictures[i].SetActive(false);
                    }
                    break;
                case "normal":
                    for(int i = 0; i < normalPictures.Length; i++) {
                        realColors[i] = normalPictures[i].GetComponent<SpriteRenderer>().color;
                        if(normalColors[i] == realColors[i]) {
                            score++;
                        }
                        normalPictures[i].SetActive(false);
                    }
                    break;
                case "hard":
                    for(int i = 0; i < hardPictures.Length; i++) {
                        realColors[i] = hardPictures[i].GetComponent<SpriteRenderer>().color;
                        if(hardColors[i] == realColors[i]) {
                            score++;
                        }
                        hardPictures[i].SetActive(false);
                    }
                    break;
            }
            
            readyBtn.gameObject.SetActive(false);
            menuBtn.SetActive(false);
            colorPalette.SetActive(false);
            gameOverPanel.SetActive(true);
        }
    }
}
