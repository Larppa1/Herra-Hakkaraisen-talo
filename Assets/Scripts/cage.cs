using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021
{
    public class cage : MonoBehaviour{
        private Vector2 cageDirection;
        public float cageSpeed;
        private Rigidbody2D cageBody;
        void Start(){
            cageBody = GetComponent<Rigidbody2D>();
        }
        void Update(){
            float directionX = Input.GetAxisRaw("Horizontal");
            cageDirection = new Vector2(directionX, 0).normalized;
        }
        void FixedUpdate(){
            cageBody.velocity = new Vector2(cageDirection.x * cageSpeed, 0);
        }
        void OnMouseDown(){
            Vector2 cageDownPos = new Vector2(cageDirection.x, -3);
            transform.position = cageDownPos;
        }
    }
}
