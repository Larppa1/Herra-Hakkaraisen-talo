using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class Goblin : MonoBehaviour {
        public float goblinSpeed;
        private Rigidbody2D goblinBody;
        private Vector2 goblinDirection;

        void Start() {
            goblinBody = GetComponent<Rigidbody2D>();
        }

        void Update() {
            goblinDirection = new Vector2(-1, 0).normalized;
        }

        void FixedUpdate() {
            goblinBody.velocity = new Vector2(goblinDirection.x * goblinSpeed, 0);
        }

        void OnMouseDown() {
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if (collision.tag == "Dragon") {
                goblinSpeed = 0;
            }
        }
    }
}