using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class ColouringManagerLegacy : MonoBehaviour{
        public GameObject clickedImage;

        void OnMouseDown(){
            switch(clickedImage.name) {
                case "topleft": clickedImage.GetComponent<SpriteRenderer>().color = ColorPicker.color; break;
                case "topright": clickedImage.GetComponent<SpriteRenderer>().material.color = ColorPicker.color; break;
                case "bottomleft": clickedImage.GetComponent<SpriteRenderer>().material.color = ColorPicker.color; break;
                case "bottomright": clickedImage.GetComponent<SpriteRenderer>().material.color = ColorPicker.color; break;
            }
        }
    }
}