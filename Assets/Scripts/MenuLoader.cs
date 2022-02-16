using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class MenuLoader : MonoBehaviour {
        public GameObject menuPanel;
        public void LoadMenu() {
            menuPanel.SetActive(true);
            Time.timeScale = 0;
        }

        public void UnloadMenu() {
            menuPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
