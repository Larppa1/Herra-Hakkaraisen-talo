using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021{
    public class FuelBar : MonoBehaviour{
        //Gameoverpanel
        public static bool isGameOver = false;

        public static float change = 1;

        // Update is called once per frame
        void Update(){
            if(transform.localScale.x > 0){
                change -= 0.00001f;
                transform.localScale = new Vector2(change, 1);
            }
            else{
                //gameOverPanel.setActive(true);
                isGameOver = true;
            }
        }

    }
}
