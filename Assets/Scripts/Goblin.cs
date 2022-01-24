using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class Goblin : MonoBehaviour {
        public float goblinSpeed;
        private Rigidbody2D goblinBody;
        private Vector2 goblinDirection;
        private float xPos;
        private float yPos;
        private Vector2 mousePos;
        private bool isHit = false;
        private int hitCount = 0;

        void Start() {
            goblinBody = GetComponent<Rigidbody2D>();
        }

        void Update() {
            goblinDirection = new Vector2(-1, 0).normalized;
        }

        void FixedUpdate() {
            goblinBody.velocity = new Vector2(goblinDirection.x * goblinSpeed, 0);
            if(isHit) {
                goblinSpeed = (float) GoblinSpeed.speed;
            }else {
                goblinSpeed = 3;
            }
        }

        void OnMouseDown() {
            xPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            yPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }

        void OnMouseDrag() {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePos.x - xPos, mousePos.y - yPos);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if (collision.tag == "Dragon") {
                hitCount++;
                if(hitCount == 1) {
                    DragonSpeed.speed += (float) 0.05;
                }
                isHit = true;
            }
        }

        private void OnTriggerExit2D(Collider2D collision) {
            if (collision.tag == "Dragon") {
                isHit = false;
            }
        }
    }
}