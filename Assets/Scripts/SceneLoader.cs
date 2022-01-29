using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace TIKO4A2021 {
    public class SceneLoader : MonoBehaviour {
        public void LoadScene(string sceneName) {
            SceneManager.LoadScene(sceneName);
            Time.timeScale = 1;
            CoinManager.amount = 0;
        }
    }
}