using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021{
    public class FuelBar : MonoBehaviour{
        //Gameoverpanel
        public static bool isGameOver = false;
        public static float timer;
        public static float current;
        private int max = 100;
        public float timerSize;
        public Image mask;
        //public int offset;

        // Update is called once per frame
        void Awake(){
            current=100;
        }
        void Update(){
            if(current > 100){
                current =100;
            }else if(current < 0){
                current = 0;
            }
            if(current > 0){
                current -= 1/timerSize;
            }else{
                //gameOverPanel.setActive(true);
                isGameOver = true;
            }
            GetCurrentFill();
        }

        void GetCurrentFill(){
            float fillAmount = (float)current / (float)max;
            mask.fillAmount = fillAmount;
        }

    }
}
