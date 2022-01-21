using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColouringManager : MonoBehaviour{
    public GameObject clickedImage;
    void OnMouseDown(){
        switch(clickedImage.name){
            case "topleft": clickedImage.GetComponent<SpriteRenderer>().material.color = Color.red; break;
            case "topright": clickedImage.GetComponent<SpriteRenderer>().material.color = Color.yellow; break;
            case "bottomleft": clickedImage.GetComponent<SpriteRenderer>().material.color = Color.green; break;
            case "bottomright": clickedImage.GetComponent<SpriteRenderer>().material.color = Color.blue; break;
        }
    }
}
