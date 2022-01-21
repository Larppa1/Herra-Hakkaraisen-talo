using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour {
    public Text countdowntext;
    private float count = 20;
    public GameObject varillinen;
    public GameObject variton;
    public GameObject variton2;
    public GameObject variton3;
    public GameObject variton4;
    public GameObject colorWheel;

    // Update is called once per frame
    void Update(){
        if(count>0){
            count -= Time.deltaTime;
            countdowntext.text = ((int)count).ToString();
        }
        else if ((int)count == 0){
            varillinen.SetActive(false);
            variton.SetActive(true);
            variton2.SetActive(true);
            variton3.SetActive(true);
            variton4.SetActive(true);
            colorWheel.SetActive(true);
        }
    }
}
