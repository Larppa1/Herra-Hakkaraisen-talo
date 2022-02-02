using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class Dragon : MonoBehaviour {
        private Rigidbody2D dragonBody;
        private Vector2 dragonDirection;
        public GameObject gameOverPanel;
        private float dragonSpeed = (float)0.5;

        void Start() {
            dragonBody = GetComponent<Rigidbody2D>();
        }

        void Update() {
            if(gameObject.transform.position.x < -4) {
                gameOverPanel.SetActive(true);
            }
            if(DragonSpeed.shakeIsActive == true){
                dragonDirection = new Vector2(1 ,0).normalized;
            }
        }
        private void OnTriggerExit2D(Collider2D collision){
            if(collision.tag == "Tree"){
                dragonSpeed = 0;
            }
        }
        void FixedUpdate(){
            dragonBody.velocity = new Vector2(dragonDirection.x * dragonSpeed ,0);
        }
    }
}
