using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class WaveSystem : MonoBehaviour {
        public Text wave, remainingEnemies;
        public static int firstWaveEnemyCount, secondWaveEnemyCount, thirdWaveEnemyCount, waveNum, score;
        public GameObject gameManager;
        void Update() {
            switch(waveNum) {
                case 0:
                wave.text = "Ensimmäinen aalto";
                remainingEnemies.text = "Vastustajia jäljellä: " + (firstWaveEnemyCount - GoblinProperties.amount).ToString();
                if(GoblinProperties.amount == firstWaveEnemyCount && gameManager.activeSelf == true) {
                    waveNum++;
                }break;
                case 1:
                wave.text = "Toinen aalto";
                remainingEnemies.text = "Vastustajia jäljellä: " + (secondWaveEnemyCount - GoblinProperties.amount).ToString();
                if(GoblinProperties.amount == secondWaveEnemyCount && gameManager.activeSelf == true) {
                    waveNum++;
                }break;
                case 2:
                wave.text = "Kolmas aalto";
                remainingEnemies.text = "Vastustajia jäljellä: " + (thirdWaveEnemyCount - GoblinProperties.amount).ToString();
                if(GoblinProperties.amount == thirdWaveEnemyCount && gameManager.activeSelf == true) {
                    waveNum++;
                }break;
            }
        }
    }
}
