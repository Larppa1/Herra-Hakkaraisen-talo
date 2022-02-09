using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TIKO4A2021 {
    public class IngredientList : MonoBehaviour {
        public Text ingredientList;
        public GameObject eggs, flour, ketchup, milk, pasta, sugar;
        public static GameObject[] ingredientArray;
        public static string ingredients = "Ainesosat kulhossa";

        void Start(){
            ingredientArray = new GameObject[]{eggs, flour, ketchup, milk, pasta, sugar};
        }
        public void Update() {
            ingredientList.text = ingredients;
        }

        public void DeleteIngredients() {
            ingredients = "Ainesosat kulhossa";
            for(int i = 0; i < ingredientArray.Length; i++) {
                ingredientArray[i].SetActive(true);
            }
        }
    }
}
