using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

namespace TIKO4A2021
{
    public class scoreDisplay : MonoBehaviour{
        public GameObject scorePanel;
        public Text scoreText;

        void Update(){
            scoreText.text = "Pisteesi ovat: " + (ColorChecker.score).ToString() + "/4";
        }
        public void GameOver(){
        scorePanel.SetActive(true);
        }

    }
}
