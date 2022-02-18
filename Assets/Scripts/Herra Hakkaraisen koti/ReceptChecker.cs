using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021
{
    public class ReceptChecker : MonoBehaviour{
        // Start is called before the first frame update
        public static int score = 0;
        private float timer = 4;
        private string[] receptArray1, receptArray2, receptArray3, receptArray4;
        private string[][] receptArrayArray;
        public Image topLeft, topRight, bottomLeft, bottomRight;
        private Image[] squareArray;
        private bool isTimerOn = false;
        public Text totalScore, timerText;
        private int random;

        void Start(){
            receptArray1 = new string[]{"eggs", "flour", "sugar", "milk"};
            receptArray2 = new string[]{"eggs", "macarons", "ketchup", "milk"};
            receptArray3 = new string[]{"eggs", "flour", "ketchup", "milk"};
            receptArray4 = new string[]{"ketchup", "flour", "sugar", "milk"};
            receptArrayArray = new string[][] {receptArray1, receptArray2, receptArray3, receptArray4};
            squareArray = new Image[]{topLeft, topRight, bottomLeft, bottomRight};
            random = Random.Range(0,4);
            squareArray[random].gameObject.SetActive(true);
        }
        void Update(){
            if(isTimerOn){
                timer -= Time.deltaTime;
                timerText.gameObject.SetActive(true);
                timerText.text = ((int)timer).ToString();
            }
            if(timer < 1){
                squareArray[random].gameObject.SetActive(false);
                isTimerOn = false;
                timerText.gameObject.SetActive(false);
                timer = 4;
                totalScore.text = "Pisteesi: " + (score).ToString();
                random = Random.Range(0,4);
                squareArray[random].gameObject.SetActive(true);
            }
        }
        private void OnTriggerEnter2D(Collider2D collision){
            if(collision.tag == "Oven" && timer == 4){
                for(int i=0; i<6; i++){
                    for(int j=0; j<4; j++){
                        if(IngredientList.ingredientArray[i].activeInHierarchy == false && IngredientList.ingredientArray[i].name == receptArrayArray[random][j]){
                            score++;
                        }
                    }
                }
            }
        }

        private void OnTriggerExit2D(Collider2D collision){
            if(collision.tag == "Oven" && BowlDrag.isReleased == true && timer == 4){
                isTimerOn = true;
                IngredientList.ingredients = "Ainesosat kulhossa";
                for(int i = 0; i < IngredientList.ingredientArray.Length; i++) {
                    IngredientList.ingredientArray[i].SetActive(true);
                }
            }
        }

    }
}
