using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021
{
    public class SimpleCountdown : MonoBehaviour{
        private float timer = 0;
        [SerializeField] private Text timerText;


    void Update(){
        timer -= Time.deltaTime;
        if(timer > 0){
            timerText.text = $"Taukoa: {(int)timer}";
        }else{
            timerText.gameObject.SetActive(false);
        }
    }

        void OnEnable(){
            timer = 20;
        }

    }
}
