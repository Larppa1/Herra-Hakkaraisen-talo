using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021 {
    public class GoblinSpeed : MonoBehaviour {
        public static double speed = 15;

        void FixedUpdate() {
            if(DragonSpeed.speed != 0) {
                speed = DragonSpeed.speed;
            }
        }
    }
}
