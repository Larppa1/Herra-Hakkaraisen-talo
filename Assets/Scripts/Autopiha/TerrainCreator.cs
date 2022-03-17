using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021
{
    public class TerrainCreator : MonoBehaviour {
        public GameObject terrain, midSection;
        private bool isCreated = false;
        private float xPos = 0;
        void Update() {
            /* if(!isCreated) {
                isCreated = true;
                Instantiate(midSection, new Vector2(xPos - 7.01f, -0.04f), transform.rotation);
                Instantiate(terrain, new Vector2(xPos, 0), transform.rotation);
            } */
            if((int)Camera.main.transform.position.x % 500 == 0 && !isCreated) {
                Instantiate(midSection, new Vector2(xPos - 7.01f, -0.04f), transform.rotation);
                Instantiate(terrain, new Vector2(xPos, 0), transform.rotation);
                xPos += 1010f;
                isCreated = true;
            }
            if((int)Camera.main.transform.position.x % 400 == 0) {
                if((int)Camera.main.transform.position.x == 0) {}
                else {
                    isCreated = false;
                }
            }
        }
    }
}
