using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021
{
    public class ShowTutorial : MonoBehaviour {
        public Image[] tutorialPhotos = new Image[5];
        public GameObject tutorialPanel, picturePanel;

        public void ShowTutorialPhoto(string gameName) {
            switch(gameName) {
                case "autopiha": 
                    tutorialPhotos[0].gameObject.SetActive(true);
                    break;
                case "kaikkien aikojen avaruus": 
                    tutorialPhotos[1].gameObject.SetActive(true);
                    break;
                case "artturin ritarien sali": 
                    tutorialPhotos[2].gameObject.SetActive(true);
                    break;
                case "galleriahuone": 
                    tutorialPhotos[3].gameObject.SetActive(true);
                    break;
                case "herra hakkaraisen koti": 
                    tutorialPhotos[4].gameObject.SetActive(true);
                    break;
            }

            picturePanel.SetActive(true);
            tutorialPanel.SetActive(false);
        }

        public void HideTutorialPhoto() {
            for(int i = 0; i < tutorialPhotos.Length; i++) {
                tutorialPhotos[i].gameObject.SetActive(false);
            }

            picturePanel.SetActive(false);
            tutorialPanel.SetActive(true);
        }
    }
}
