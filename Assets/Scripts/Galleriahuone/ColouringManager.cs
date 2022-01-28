using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class ColouringManager : MonoBehaviour {
        void OnMouseDown() {
            ColorPicker.color = GetComponent<SpriteRenderer>().color;
        }
    }
}
