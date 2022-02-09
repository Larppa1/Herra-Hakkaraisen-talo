using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021
{
    public class RoundTimer : MonoBehaviour {
        public Text timerText;
        void Update() {
            if(KitchenDifficulty.roundTime > 0) {
                KitchenDifficulty.roundTime -= Time.deltaTime;
                timerText.text = "Aikaa jäljellä: " + ((int)KitchenDifficulty.roundTime).ToString();
            }
        }
    }
}
