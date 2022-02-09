using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class IngredientDrag : MonoBehaviour {
        private float xPos, yPos, originalX, originalY;
        private Vector2 mousePos;
        private bool isOnTopOfBowl = false, isReleased = false;
        [SerializeField] private string ingredientName;

        void Update() {
            if(isOnTopOfBowl && isReleased) {
                this.gameObject.SetActive(false);
                transform.position = new Vector2(originalX, originalY);
                IngredientList.ingredients += Environment.NewLine + ingredientName;
            }
        }
        
        void OnMouseDown() {
            isReleased = false;
            xPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            yPos = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
            originalX = transform.position.x;
            originalY = transform.position.y;
        }
        
        void OnMouseDrag() {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePos.x - xPos, mousePos.y - yPos);
        }

        void OnMouseUp() {
            isReleased = true;
            if(!isOnTopOfBowl) {
                transform.position = new Vector2(originalX, originalY);
            }
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if(collision.tag == "Bowl") {
                isOnTopOfBowl = true;
            }
        }

        private void OnTriggerExit2D(Collider2D collision) {
            if(collision.tag == "Bowl") {
                isOnTopOfBowl = false;
            }
        }
    }
}
