using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class ColorChecker : MonoBehaviour {
        public Button readyBtn;
        public GameObject topLeft, topRight, bottomLeft, bottomRight;
        private static Color topLeftColored, topRightColored, bottomLeftColored, bottomRightColored;
        public static int score = 0;
        public static bool counted = false;
        private Dictionary<GameObject, Color> galleryDictionary = new Dictionary<GameObject, Color>();
        private GameObject[] imageArray;
        private Color[] colorArray = new Color[] {Color.red, Color.yellow, Color.green, Color.blue};

        void Start() {
            readyBtn.onClick.AddListener(CheckColors);
        }

        void CheckColors() {

            topLeftColored = topLeft.GetComponent<SpriteRenderer>().color;
            topRightColored = topRight.GetComponent<SpriteRenderer>().color;
            bottomLeftColored = bottomLeft.GetComponent<SpriteRenderer>().color;
            bottomRightColored = bottomRight.GetComponent<SpriteRenderer>().color;
            imageArray = new GameObject[] {topLeft, topRight, bottomLeft, bottomRight};
                for(int i = 0; i<4;i++){
                    galleryDictionary.Add(imageArray[i],colorArray[i]);
                }

            if(topLeftColored == galleryDictionary[imageArray[0]]) {
                score++;
            }
            if(topRightColored == galleryDictionary[imageArray[1]]) {
                score++;
            }
            if(bottomLeftColored ==galleryDictionary[imageArray[2]]) {
                score++;
            }
            if(bottomRightColored == galleryDictionary[imageArray[3]]) {
                score++;
            }
            
            readyBtn.gameObject.SetActive(false);
        }
    }
}
