using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class Dragon : MonoBehaviour {
        private float dragonSpeed;
        private Rigidbody2D dragonBody;
        private Vector2 dragonDirection;
        public GameObject gameOverPanel;

        void Start() {
            dragonBody = GetComponent<Rigidbody2D>();
        }
        private void OnTriggerEnter2D(Collider2D collision) {
            if (collision.tag == "Goblin") {
                dragonSpeed = (float) DragonSpeed.speed;
                dragonDirection = new Vector2(-1, 0).normalized;
            }
        }

        void Update() {
            if(gameObject.transform.position.x < -4.1) {
                gameOverPanel.SetActive(true);
            }
        }

        void FixedUpdate() {
            dragonBody.velocity = new Vector2(dragonDirection.x * dragonSpeed, 0);
        }
    }
}
