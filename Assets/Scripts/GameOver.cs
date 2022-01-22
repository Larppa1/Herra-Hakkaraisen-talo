using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace TIKO4A2021 {
    public class GameOver : MonoBehaviour {
        public GameObject gameOverPanel;

        void Update() {
            if(GameObject.FindGameObjectWithTag("Player") == null) {
                gameOverPanel.SetActive(true);
            }
        }

        public void Restart() {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}