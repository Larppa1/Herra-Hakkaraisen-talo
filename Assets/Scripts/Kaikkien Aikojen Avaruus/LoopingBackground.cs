using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class LoopingBackground : MonoBehaviour {
        public float backgroundSpeed;
        public Renderer backgroundRenderer;

        void Update() {
            backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
        }
        public void StopBackground(){
            backgroundSpeed = 0;
        }
    }
}