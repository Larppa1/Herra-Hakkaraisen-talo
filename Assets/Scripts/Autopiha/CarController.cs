using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021
{
    public class CarController : MonoBehaviour{
        public Rigidbody2D frontWheel, backWheel, car;
        public Canvas mainCanvas, gameOverCanvas;
        public Text finalScoreText;
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
                input = -ButtonHandler.direction;
            }
            else{
                speed= 0;
                torque = 0;
                isFlipped = true;
                Invoke("GameOver", 3);
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
            finalScoreText.text = "Pisteet: " + ((int)ScoreSystem.score).ToString();
            isFlipped = false;
        }
    }
}
