using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class Instructions : MonoBehaviour {
        public GameObject instructionsPanel;
        public Button openBtn, closeBtn;

        void Awake() {
            openBtn.onClick.AddListener(ClickedBtn);
            closeBtn.onClick.AddListener(ClickedBtn);
        }

        void ClickedBtn() {
            if(instructionsPanel.gameObject.activeSelf) {
                instructionsPanel.SetActive(false);
                openBtn.gameObject.SetActive(true);
            }else {
                instructionsPanel.SetActive(true);
                openBtn.gameObject.SetActive(false);
            }
        }
    }
}
