using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace TIKO4A2021 {
    public class BusWheel : MonoBehaviour {
        void Start() {
            transform.DOLocalRotate(new Vector3(0, 0, -108000), 600, RotateMode.FastBeyond360);
        }
    }
}
