using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class CoinManager : MonoBehaviour {
        public static int amount = 0;
        public Text coinText;

        void Update() {
            coinText.text = (amount).ToString();
        }
    }
}
