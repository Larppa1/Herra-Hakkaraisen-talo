using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {
    public Text countdowntext;
    private float count = 20;

    // Update is called once per frame
    void Update(){
        if(count>0){
            count -= Time.deltaTime;
            countdowntext.text = ((int)count).ToString();
        }
    }
}
