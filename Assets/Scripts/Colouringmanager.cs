using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class ColouringManager : MonoBehaviour{
        public GameObject clickedImage;
        public Texture2D map;
        private Vector2 mousePosition;
        private Color32 color;

        void OnMouseDown(){
            switch(clickedImage.name) {
                case "colourwheel3": mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y); GetColor(); break;
                case "topleft": clickedImage.GetComponent<SpriteRenderer>().color = new Color32(/*??????*/); break;
                case "topright": clickedImage.GetComponent<Renderer>().material.color = color; break;
                case "bottomleft": clickedImage.GetComponent<Renderer>().material.color = color; break;
                case "bottomright": clickedImage.GetComponent<Renderer>().material.color = color; break;
            }
        }

        void GetColor() {
            Vector2 screenSize = new Vector2(Screen.width, Screen.height);
            Vector2 textureSize = new Vector2(map.width, map.height);
            Vector2 textureScreenPosition = Camera.main.WorldToScreenPoint(clickedImage.transform.position);
            Vector2 textureStartPosition = textureScreenPosition - textureSize / 2;
            Vector2 relativeClickPosition = mousePosition - textureStartPosition;

            color = map.GetPixel((int)relativeClickPosition.x, (int)relativeClickPosition.y);
            Debug.Log(color);
        }
    }
}