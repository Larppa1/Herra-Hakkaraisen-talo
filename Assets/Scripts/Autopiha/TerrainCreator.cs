using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021
{
    public class TerrainCreator : MonoBehaviour {
        public GameObject terrain;
        private bool isCreated = false;
        private float xPos = 0;
        void Update() {
            if((int)Camera.main.transform.position.x % 900 == 0 && !isCreated) {
                Instantiate(terrain, new Vector2(xPos, 0), Quaternion.identity);
                isCreated = true;
            }
            if((int)Camera.main.transform.position.x % 500 == 0 && isCreated) {
                if((int)Camera.main.transform.position.x == 0) {}
                else {
                    isCreated = false;
                    xPos += 1004.5f;
                }
            }
        }
    }
}
