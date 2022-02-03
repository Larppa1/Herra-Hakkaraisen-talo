using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class Dragon : MonoBehaviour {
        private Rigidbody2D dragonBody;
        private Vector2 dragonDirection;
        private float dragonSpeed = (float)0.3;
        public GameObject gameOverPanel;

        void Start() {
            dragonBody = GetComponent<Rigidbody2D>();
        }

        void Update() {
            if(DragonSpeed.shakeIsActive == true){
                dragonBody.constraints = RigidbodyConstraints2D.None;
                dragonDirection = new Vector2(1 ,0).normalized;
            }else if(DragonSpeed.shakeIsActive == false && transform.position.x > 8) {
                dragonBody.constraints = RigidbodyConstraints2D.FreezePosition;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if(collision.tag == "DragonAnnihilator3000") {
                gameOverPanel.SetActive(true);
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
