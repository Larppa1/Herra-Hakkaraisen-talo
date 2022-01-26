using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace TIKO4A2021 {
    public class Bus : MonoBehaviour {
        public float playerSpeed;
        private Rigidbody2D busBody;
        private Vector2 playerDirection;

        void Start() {
            busBody = GetComponent<Rigidbody2D>();
        }

        void Update() {
            float directionY = Input.GetAxisRaw("Vertical");
            playerDirection = new Vector2(0, directionY).normalized;

            if(Input.GetKey("up")) {
                transform.DORotate(new Vector3(0, 0, 2), 0).SetEase(Ease.Linear);
            }else if(Input.GetKey("down")) {
                transform.DORotate(new Vector3(0, 0, -2), 0).SetEase(Ease.Linear);
            }

            if(Input.GetKeyUp("up") || Input.GetKeyUp("down")) {
                transform.DORotate(new Vector3(0, 0, 0), 0).SetEase(Ease.Linear);
            }
        }

        void FixedUpdate() {
            busBody.velocity = new Vector2(0, playerDirection.y * playerSpeed);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if(collision.tag == "Coin") {
                CoinCount.amount += 5;
            }else if(collision.tag == "Coin2") {
                CoinCount.amount += 10;
            }else if(collision.tag == "Coin3") {
                CoinCount.amount += 15;
            }
        }
    }
}