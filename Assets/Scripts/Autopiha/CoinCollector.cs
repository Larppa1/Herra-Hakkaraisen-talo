using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class CoinCollector : MonoBehaviour {
        
        private void OnTriggerEnter2D(Collider2D collision) {
            switch(collision.tag) {
                case "Coin": CoinManager.amount += 5; break;
                case "Coin2": CoinManager.amount += 10; break;
                case "Coin3": CoinManager.amount += 15; break;
                case "JerryCan": 
                    FuelBar.current += 40;
                    break;
                case "GasStation": 
                    FuelBar.current = 100; 
                    break;
            }
        }
    }
}
