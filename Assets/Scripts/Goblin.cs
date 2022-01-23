using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class Goblin : MonoBehaviour {
        public float goblinSpeed;
        private Rigidbody2D goblinBody;
        private Vector2 goblinDirection;
        private bool isHit = false;

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
            }
        }

        void OnMouseDown() {
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if (collision.tag == "Dragon") {
                DragonSpeed.speed += (float) 0.05;
                isHit = true;
            }
        }
    }
}