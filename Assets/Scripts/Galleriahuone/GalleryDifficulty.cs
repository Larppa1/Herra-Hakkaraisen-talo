using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021{
    public class GalleryDifficulty : MonoBehaviour{
        public GameObject gameManager, difficultyPanel, canvas;
        public static float countSize;
        public void GalleryDifficultyLevel(string difficultyLevel){
            switch(difficultyLevel){
                case "easy":
                    countSize = 20;
                    break;
                case "normal":
                    countSize = 15;
                    break;
                case "hard":
                    countSize = 10;
                    break;
            }
            gameManager.SetActive(true);
            difficultyPanel.SetActive(false);
            canvas.SetActive(true);
        }

    }
}
