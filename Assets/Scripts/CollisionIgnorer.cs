using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TIKO4A2021
{
    public class CollisionIgnorer : MonoBehaviour{
        public GameObject collisionTarget;
        void Start(){
        Physics2D.IgnoreCollision(collisionTarget.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
