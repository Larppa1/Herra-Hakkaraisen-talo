using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class Coin : MonoBehaviour {
        private Rigidbody2D coinBody;

        void Start() {
            coinBody = GetComponent<Rigidbody2D>();
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if(collision.tag == "Border" || collision.tag == "Player") {
                Destroy(this.gameObject);
            }
        }
    }
}
