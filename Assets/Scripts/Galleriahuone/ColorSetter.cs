using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class ColorSetter : MonoBehaviour {
        void OnMouseDown() {
            if(ColorChecker.counted == true){
                GetComponent<SpriteRenderer>().color = ColorPicker.color;
            }
        }
    }
}
