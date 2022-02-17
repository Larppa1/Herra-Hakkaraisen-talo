using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021
{
    public class CarController : MonoBehaviour{
        public Rigidbody2D frontWheel, backWheel, car;
        public Canvas mainCanvas, gameOverCanvas;
        public float torque = -100f, speed = 50f;
        float input;
        private bool isFlipped;

        void FixedUpdate(){
            frontWheel.AddTorque(input * speed * Time.fixedDeltaTime);
            backWheel.AddTorque(input * speed * Time.fixedDeltaTime);
            car.AddTorque(input * speed * Time.fixedDeltaTime);
        }

        // Update is called once per frame
        void Update(){
            if(!FuelBar.isGameOver){
                input = -Input.GetAxisRaw("Horizontal");
            }
            else{
                speed= 0;
                torque = 0;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if(collision.tag == "Ground") {
                isFlipped = true;
                Invoke("GameOver", 3);
            }
        }
        private void OnTriggerExit2D(Collider2D collision) {
            if(collision.tag == "Ground") {
                isFlipped = false;
            }
        }

        private void GameOver() {
            if(!isFlipped) return;

            gameOverCanvas.gameObject.SetActive(true);
            mainCanvas.gameObject.SetActive(false);
        }
    }
}
