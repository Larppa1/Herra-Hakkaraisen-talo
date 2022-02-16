using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;

namespace TIKO4A2021
{
    public class scoreDisplay : MonoBehaviour{
        public Text scoreText;

        void Update(){
            scoreText.text = "Pisteet: " + (ColorChecker.score).ToString() + " / 10";
        }

    }
}
