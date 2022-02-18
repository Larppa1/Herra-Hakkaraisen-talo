using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;

namespace TIKO4A2021 {
    public class Bus : MonoBehaviour {
        public float busSpeed;
        private Rigidbody2D busBody;
        public static Vector2 busDirection;

        //Method Start gets Rigidbody2D from Bus GameObject and saves it to variable busBody.
        void Start() {
            busBody = GetComponent<Rigidbody2D>();
        }

        //Method Update gets vertical direction from user input and changes bus direction according to the direction.
        //If user presses key to go up or down, the method uses DOTween to angle the bus up or down, depending on
        //the direction. When user stops pressing the key, the bus will rotate back to original angle.
        void Update() {
            float directionY = Input.GetAxisRaw("Vertical");
            busDirection = new Vector2(0, directionY).normalized;

            //Rotation 2 degrees up if user input is arrow up or W. Rotation 2 degrees down if user input is arrow down or S.
            if(Input.GetKey("up")) {
                transform.DORotate(new Vector3(0, 0, 2), 0).SetEase(Ease.Linear);
            }else if(Input.GetKey("down")) {
                transform.DORotate(new Vector3(0, 0, -2), 0).SetEase(Ease.Linear);
            }

            //Rotation back to original level when user stops pressing arrow up, arrow down, W or S.
            if(Input.GetKeyUp("up") || Input.GetKeyUp("down")) {
                transform.DORotate(new Vector3(0, 0, 0), 0).SetEase(Ease.Linear);
            }
        }

        //Method FixedUpdate changes Bus GameObject's velocity according to variables busDirection.y and busSpeed.
        void FixedUpdate() {
            busBody.velocity = new Vector2(0, busDirection.y * busSpeed);
        }

        //Method OnTriggerEnter2D listens for collisions between Bus GameObject and different Coin GameObjects.
        //When tag is Coin, CoinCount.amount will increase by 5.
        //When tag is Coin2, CoinCount.amount will increase by 10.
        //When tag is Coin3, CoinCount.amount will increase by 15.
        private void OnTriggerEnter2D(Collider2D collision) {
            switch(collision.tag) {
                case "Coin": CoinManager.amount += 5; break;
                case "Coin2": CoinManager.amount += 10; break;
                case "Coin3": CoinManager.amount += 15; break;
            }
        }
    }
}