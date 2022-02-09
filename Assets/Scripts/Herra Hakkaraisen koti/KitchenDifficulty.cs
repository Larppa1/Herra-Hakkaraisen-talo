using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021{
    public class KitchenDifficulty : MonoBehaviour{
        public GameObject gameManager, difficultyPanel;
        public static float roundTime;
        public void KitchenDifficultyLevel(string difficultyLevel){
            switch(difficultyLevel){
                case "easy":
                    roundTime = 90;
                    break;
                case "normal":
                    roundTime = 60;
                    break;
                case "hard":
                    roundTime = 30;
                    break;
            }
            gameManager.SetActive(true);
            difficultyPanel.SetActive(false);
        }
    }
}
