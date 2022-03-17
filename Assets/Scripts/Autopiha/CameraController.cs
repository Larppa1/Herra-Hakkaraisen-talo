using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021
{
    public class CameraController : MonoBehaviour{
        public Transform player;
        private float offset = 2.8f;

        // Update is called once per frame
        void Update(){
        Camera.main.transform.position = new Vector3(player.position.x + offset , player.position.y + 1.3f, -10);
        }
    }
}
