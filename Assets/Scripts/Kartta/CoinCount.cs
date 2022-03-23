using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class CoinCount : MonoBehaviour {
        public Text coinAmount;

        void Update() {
            coinAmount.text = (PlayerPrefs.GetInt("coinCount")).ToString();
        }

    }
}
