using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace TIKO4A2021
{
    public class Trees : MonoBehaviour{
        private float count = 15;
        private bool isShaking = false;

        void Update(){
            if(isShaking == true){
                count -= Time.deltaTime;
                Debug.Log(count);
            }
            if(count < 0){
                Destroy(this.gameObject);
            }
        }

        private void OnTriggerStay2D(Collider2D collision){
            if(collision.tag== "Goblin" && DOTween.TotalActiveTweens() == 0){
                gameObject.transform.DOShakeRotation(2,8,8,20);
                isShaking = true;
                DragonSpeed.shakeIsActive = true;
            }
        }
        private void OnTriggerExit2D(Collider2D collision){
            if(collision.tag== "Goblin"){
                isShaking = false;
                DragonSpeed.shakeIsActive = false;
            }
        }
    }
}
