using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021{
    public class Fader : MonoBehaviour{
            public enum FadeState{
                None,
                FadeIn,
                FadeOut
            }
            private FadeState state = FadeState.None;
            [SerializeField] private Image background;
            [SerializeField] private float speed = 1;
            private Color bgColor;
        void Start(){
        bgColor = background.color;
        bgColor.a = 0;
        background.color = bgColor;
        }

        // Update is called once per frame
        void Update(){
        switch(state){
            case FadeState.FadeIn:
                bgColor.a += Mathf.Clamp01(Time.deltaTime * speed);
                background.color = bgColor;
                if(bgColor.a == 1){
                    state = FadeState.None;
                }
                break;
            case FadeState.FadeOut:
                bgColor.a -= Mathf.Clamp01(Time.deltaTime * speed);
                background.color = bgColor;
                if(bgColor.a == 0){
                    state = FadeState.None;
                }
                break;
            case FadeState.None:
            break;
        }
        }

        public float FadeIn(){
            state = FadeState.FadeIn;
            return 1/speed;
        }
        public float FadeOut(){
            state = FadeState.FadeOut;
            return 1/speed;
        }

    }
}
