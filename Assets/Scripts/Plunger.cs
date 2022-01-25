using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace TIKO4A2021
{
    public class Plunger : MonoBehaviour{
        private Vector2 plungerDirection;
        public float plungerSpeed;
        private Rigidbody2D plungerBody;
        private bool isMoved = false;
        void Start(){
            plungerBody = GetComponent<Rigidbody2D>();
        }
        void Update(){
            float directionX = Input.GetAxisRaw("Horizontal");
            plungerDirection = new Vector2(directionX, 0).normalized;
            PlungerProperties.position = transform.position;
            
            if(Input.GetKeyDown("down")) {
                transform.DOMove(new Vector2(transform.position.x, -3), 1).SetLoops(1, LoopType.Yoyo);
                isMoved = true;
            }

            if(isMoved && PlungerProperties.isCaught) {
                transform.DOMove(new Vector2(transform.position.x, 10), 1).SetLoops(1, LoopType.Yoyo);
                isMoved = false;
            }else if(isMoved) {
                transform.DOMove(new Vector2(transform.position.x, 3), 1).SetLoops(1, LoopType.Yoyo);
                isMoved = false;
            }
        }
        void FixedUpdate(){
            plungerBody.velocity = new Vector2(plungerDirection.x * plungerSpeed, 0);
        }
    }
}
