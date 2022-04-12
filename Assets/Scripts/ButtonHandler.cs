using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TIKO4A2021{
    public class ButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler{
        public string buttonName;
        public static bool isDown = false;
        public static float direction = 0;
        public void OnPointerDown(PointerEventData eventData){
                switch(buttonName){
                    case "Negative":
                    direction = -1f; break;
                    case "Positive":
                    direction = 1f; break;
                    case "Down": 
                    isDown = true; break;
                }
        }
        public void OnPointerUp(PointerEventData eventData){
            direction = 0;
        }
    }
}
