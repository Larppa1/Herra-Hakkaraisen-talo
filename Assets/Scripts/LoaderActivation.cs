using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021{
    public class LoaderActivation : MonoBehaviour{

        public void Activate(GameObject sceneLoader){
            sceneLoader.SetActive(true);
        }

    }
}
