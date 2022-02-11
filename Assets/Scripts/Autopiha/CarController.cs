using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021
{
    public class CarController : MonoBehaviour{
        public Rigidbody2D frontWheel;
        public Rigidbody2D backWheel;
        public Rigidbody2D car;
        public float torque = -100f;
        public float speed = 50f;
        float input;

        void FixedUpdate(){
            frontWheel.AddTorque(input * speed * Time.fixedDeltaTime);
            backWheel.AddTorque(input * speed * Time.fixedDeltaTime);
            car.AddTorque(input * speed * Time.fixedDeltaTime);
        }

        // Update is called once per frame
        void Update(){
            input = -Input.GetAxisRaw("Horizontal");
        }
    }
}
