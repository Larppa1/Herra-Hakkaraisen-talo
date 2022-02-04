using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace TIKO4A2021 {
    public class Obstacle : MonoBehaviour{
        private GameObject player;
        private Rigidbody2D obstacleBody;

        void Start() {
            obstacleBody = GetComponent<Rigidbody2D>();
            player = GameObject.FindGameObjectWithTag("Player");
            transform.DORotate(new Vector3(0, 0, 720), 5, RotateMode.FastBeyond360);
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            switch(collision.tag) {
                case "Border":
                    MeteorProperties.meteorCount++;
                    Destroy(this.gameObject);
                    break;
                case "Player":
                    Destroy(player.gameObject);
                    break;
            }
        }
    }
}