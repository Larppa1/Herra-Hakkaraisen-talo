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
            if(current > 0){
                current -= Time.deltaTime;
            }else{
                isGameOver = true;
            }
            GetCurrentFill();
        }
        void FixedUpdate(){

        }

        void GetCurrentFill(){
            float fillAmount = current / (float)max;
            mask.fillAmount = fillAmount;
        }

    }
}
