using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace TIKO4A2021
{
    public class Plunger : MonoBehaviour{
        private Vector2 plungerDirection;
        public float plungerSpeed;
        public GameObject enemy;
        private Rigidbody2D plungerBody;
        private int count = 0;
        private bool isRemoved = true;

        void Start(){
            plungerBody = GetComponent<Rigidbody2D>();
        }
        void Update(){
            float directionX = Input.GetAxisRaw("Horizontal");
            plungerDirection = new Vector2(directionX, 0).normalized;
            PlungerProperties.position = transform.position;
            
            if(Input.GetKeyDown("down")) {
                transform.DOMove(new Vector2(transform.position.x, -3), 1).SetLoops(2, LoopType.Yoyo);
            }

            if(transform.position.y > 3 && PlungerProperties.isCaught) {
                if(count == 0) {
                    transform.DOMove(new Vector2(transform.position.x, 10), 1).SetLoops(2, LoopType.Yoyo);
                    isRemoved = false;
                }
                count++;
            }
        }
        void FixedUpdate(){
            plungerBody.velocity = new Vector2(plungerDirection.x * plungerSpeed, 0);
        }

        private void OnTriggerStay2D(Collider2D collision) {
            if(collision.tag == "Goblin") {
                if(transform.position.y > 8 && isRemoved == false) {
                    //Destroy enemy
                    //isRemoved = true;
                    //PlungerProperties.isCaught = false;
                }
            }
        }
    }
}
