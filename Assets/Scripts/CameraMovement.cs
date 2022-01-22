using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TIKO4A2021 {
    public class CameraMovement : MonoBehaviour {
        public float cameraSpeed;

        void Update() {
            transform.position = new Vector2(cameraSpeed * Time.deltaTime, 0);
        }
    }
}