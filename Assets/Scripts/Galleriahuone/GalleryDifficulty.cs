using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021{
    public class GalleryDifficulty : MonoBehaviour{
        public GameObject gameManager, difficultyPanel, canvas, easyReal, normalReal, hardReal;
        public static float countSize;
        public static string difficulty;
        public void GalleryDifficultyLevel(string difficultyLevel){
            switch(difficultyLevel){
                case "easy":
                    countSize = 20;
                    easyReal.SetActive(true);
                    break;
                case "normal":
                    countSize = 15;
                    normalReal.SetActive(true);
                    break;
                case "hard":
                    countSize = 10;
                    hardReal.SetActive(true);
                    break;
            }
            difficulty = difficultyLevel;
            gameManager.SetActive(true);
            difficultyPanel.SetActive(false);
            canvas.SetActive(true);
        }
    }
}
