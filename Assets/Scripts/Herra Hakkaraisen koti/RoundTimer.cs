using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021
{
    public class RoundTimer : MonoBehaviour {
        public Text timerText, scoreText;
        public GameObject gameOverPanel, squares;
        public Canvas mainCanvas;
        void Update() {
            if((int)KitchenDifficulty.roundTime > 0) {
                KitchenDifficulty.roundTime -= Time.deltaTime;
                timerText.text = "Aikaa jäljellä: " + ((int)KitchenDifficulty.roundTime).ToString();
            }else if((int)KitchenDifficulty.roundTime == 0) {
                scoreText.text = "Pisteet: " + (ReceptChecker.score).ToString();
                gameOverPanel.SetActive(true);
                mainCanvas.gameObject.SetActive(false);
                squares.SetActive(false);
            }
        }
    }
}
