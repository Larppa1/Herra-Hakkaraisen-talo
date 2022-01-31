using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class Dragon : MonoBehaviour {
        private float dragonSpeed = 0;
        private Rigidbody2D dragonBody;
        private Vector2 dragonDirection;
        public GameObject gameOverPanel;

        void Start() {
            dragonBody = GetComponent<Rigidbody2D>();
        }
        private void OnTriggerStay2D(Collider2D collision) {
            if(collision.tag == "Goblin" || collision.tag == "Goblin2"){
                dragonSpeed = 1;
                dragonDirection = new Vector2(0, 1);
            }
        }
                private void OnTriggerExit2D(Collider2D collision) {
            if(collision.tag == "Goblin" || collision.tag == "Goblin2"){
                dragonSpeed = 0;
            }
        }

        void Update() {
            if(gameObject.transform.position.x < -4) {
                gameOverPanel.SetActive(true);
            }
            DragonSpeed.yPos = transform.position.y;
            if(transform.position.y > 0.5){
                dragonDirection = new Vector2(1,0);
            }
        }

        void FixedUpdate() {
            dragonBody.velocity = new Vector2(dragonDirection.x * dragonSpeed , dragonDirection.y * dragonSpeed);
        }

    }
}
