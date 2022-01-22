using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class Coin : MonoBehaviour {
        private Vector2 coinDirection;
        public float coinSpeed;
        private Rigidbody2D coinBody;

        void Start() {
            coinBody = GetComponent<Rigidbody2D>();
        }

        void Update() {
            coinDirection = new Vector2(-1, 0).normalized;
        }

        void FixedUpdate() {
            coinBody.velocity = new Vector2(coinDirection.x * coinSpeed, 0);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if(collision.tag == "Border" || collision.tag == "Player") {
                Destroy(this.gameObject);
            }
        }
    }
}
