using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021
{
    public class TerrainCreator : MonoBehaviour {
        public GameObject terrain;
        private bool isCreated = true;
        private float xPos = 0;

        void Awake() {
            Instantiate(terrain, new Vector2(xPos, 0), Quaternion.identity);
        }
        void Update() {
            if((int)Camera.main.transform.position.x % 900 != 0 && !isCreated) {
                Instantiate(terrain, new Vector2(xPos + 6.5f, 0), Quaternion.identity);
                isCreated = true;
            }else if((int)Camera.main.transform.position.x % 500 != 0 && isCreated) {
                xPos += 1000;
                isCreated = false;
            }
        }
    }
}
