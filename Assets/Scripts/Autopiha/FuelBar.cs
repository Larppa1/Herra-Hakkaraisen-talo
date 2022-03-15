using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021{
    public class FuelBar : MonoBehaviour{
        //Gameoverpanel
        public static bool isGameOver = false;
        public static float timer, current;
        private int max = 100;
        [SerializeField] private float timerSize;
        public Image mask;

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
            GetCurrentFill();
        }
        void FixedUpdate(){
            if(current > 0){
                current -= 1/timerSize;
            }else{
                isGameOver = true;
            }
        }

        void GetCurrentFill(){
            float fillAmount = current / (float)max;
            mask.fillAmount = fillAmount;
        }

    }
}
