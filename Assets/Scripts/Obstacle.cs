using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class Obstacle : MonoBehaviour{
        private GameObject player;
        private Vector2 obstacleDirection;
        public float obstacleSpeed;
        private Rigidbody2D obstacleBody;
        private int frameCount = 0;

        void Start() {
            obstacleBody = GetComponent<Rigidbody2D>();
            player = GameObject.FindGameObjectWithTag("Player");
        }

        void Update() {
            obstacleDirection = new Vector2(-1, 0).normalized;
            if(frameCount % 4 == 0) {
                transform.Rotate(0, 0, 1);
                frameCount = 1;
            }
            frameCount++;
        }

        void FixedUpdate() {
            obstacleBody.velocity = new Vector2(obstacleDirection.x * obstacleSpeed, 0);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if(collision.tag == "Border") {
                Destroy(this.gameObject);
            }else if(collision.tag == "Player") {
                Destroy(player.gameObject);
            }
        }
    }
}