using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021
{
    public class Difficulty : MonoBehaviour {
        public GameObject gameManager;
        public GameObject difficultyPanel;
        public GameObject canvas;
        public void EnemyAmount(int enemyAmountTotal) {
            switch(enemyAmountTotal) {
                case 60:
                    WaveSystem.firstWaveEnemyCount = 10;
                    WaveSystem.secondWaveEnemyCount = 30;
                    WaveSystem.thirdWaveEnemyCount = 60;
                    break;
                case 90:
                    WaveSystem.firstWaveEnemyCount = 20;
                    WaveSystem.secondWaveEnemyCount = 50;
                    WaveSystem.thirdWaveEnemyCount = 90;
                    break;
                case 120:
                    WaveSystem.firstWaveEnemyCount = 30;
                    WaveSystem.secondWaveEnemyCount = 70;
                    WaveSystem.thirdWaveEnemyCount = 120;
                    break;
            }
            gameManager.SetActive(true);
            difficultyPanel.SetActive(false);
            canvas.SetActive(true);
        }
    }
}
