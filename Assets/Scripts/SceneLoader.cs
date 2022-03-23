using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TIKO4A2021 {
    public class SceneLoader : MonoBehaviour {
        public void LoadScene(string sceneName) {
            Time.timeScale = 1;
            LoadScreen.Current.LoadLevel(sceneName);
            CoinManager.amount = 0;
            WaveSystem.waveNum = 0;
            GoblinProperties.amount = 0;
            DragonSpeed.shakeIsActive = false;
            ColorChecker.score = 0;
            ColorChecker.counted = false;
            Countdown.coloringTimer = 0;
            KitchenDifficulty.roundTime = -1;
            FuelBar.isGameOver = false;
        }

    }
}