using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class MeteorProperties : MonoBehaviour {
        public static int meteorCount, coinCount;
        public static float meteorPosX, meteorPosY;
        [SerializeField] private Text scoreText;

        public void DestroyMeteors(){
            GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("Goblin");
            foreach (GameObject item in taggedObjects) {
                Destroy(item);
            }
            scoreText.enabled = false;
        }

    }
}
