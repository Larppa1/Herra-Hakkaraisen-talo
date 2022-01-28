using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class CoinAmount : MonoBehaviour {
        public Text coinText;
        void Update() {
            coinText.text = (CoinCount.amount).ToString();
        }
    }
}
