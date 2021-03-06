using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

namespace TIKO4A2021 {
    public class TerrainController : MonoBehaviour {
        private SpriteShapeController shape;
        public int scale;
        public GameObject coin, coin2, coin3, jerryCan, tree1, tree2;

        void Awake() {
            shape = this.GetComponent<SpriteShapeController>();
            int amountOfPoints = scale / 6;
            float distanceBetweenPoints = (float)scale / (float)amountOfPoints;

            shape.spline.SetPosition(2, shape.spline.GetPosition(2) + Vector3.right * scale);
            shape.spline.SetPosition(3, shape.spline.GetPosition(3) + Vector3.right * scale);

            for(int i = 0; i < amountOfPoints; i++) {
                float xPos = shape.spline.GetPosition(i + 1).x + distanceBetweenPoints;
                if(i < 5 || i > amountOfPoints - 5) {
                    shape.spline.InsertPointAt(i + 2, new Vector2(xPos, 6 * Mathf.PerlinNoise(i * Random.Range(0.0f, 0.0f), 0)));
                }else if((i >= 5 && i < 10) || i > amountOfPoints - 20) {
                    shape.spline.InsertPointAt(i + 2, new Vector2(xPos, 6 * Mathf.PerlinNoise(i * Random.Range(0.0f, 3.0f), 0)));
                }else {
                    shape.spline.InsertPointAt(i + 2, new Vector2(xPos, 11 * Mathf.PerlinNoise(i * Random.Range(5.0f, 14.0f), 0)));
                }
                if(i == 0) {
                    
                }else if(i % 80 == 0) {
                    Instantiate(coin3, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i)).x, transform.TransformPoint(shape.spline.GetPosition(i)).y + 1), transform.rotation);
                    int treePicker = Random.Range(0, 2);
                    if(treePicker == 0) {
                        Instantiate(tree1, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i+1)).x, transform.TransformPoint(shape.spline.GetPosition(i+1)).y + 3), transform.rotation);
                    }else {
                        Instantiate(tree2, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i+2)).x, transform.TransformPoint(shape.spline.GetPosition(i+2)).y + 3), transform.rotation);
                    }
                }else if(i % 40 == 0) {
                    Instantiate(jerryCan, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i+2)).x, transform.TransformPoint(shape.spline.GetPosition(i+2)).y + 1), transform.rotation);
                    Instantiate(coin2, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i)).x, transform.TransformPoint(shape.spline.GetPosition(i)).y + 1), transform.rotation);
                    int treePicker = Random.Range(0, 2);
                    if(treePicker == 0) {
                        Instantiate(tree1, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i+2)).x, transform.TransformPoint(shape.spline.GetPosition(i+2)).y + 3), transform.rotation);
                    }else {
                        Instantiate(tree2, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i+1)).x, transform.TransformPoint(shape.spline.GetPosition(i+1)).y + 3), transform.rotation);
                    }
                }else if(i % 10 == 0) {
                    Instantiate(coin, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i)).x, transform.TransformPoint(shape.spline.GetPosition(i)).y + 1), transform.rotation);
                    int treePicker = Random.Range(0, 2);
                    if(treePicker == 0) {
                        Instantiate(tree1, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i+1)).x, transform.TransformPoint(shape.spline.GetPosition(i+1)).y + 3), transform.rotation);
                    }else {
                        Instantiate(tree2, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i+1)).x, transform.TransformPoint(shape.spline.GetPosition(i+1)).y + 3), transform.rotation);
                    }
                }else if(i % 5 == 0) {
                    int treePicker = Random.Range(0, 2);
                    if(treePicker == 0) {
                        Instantiate(tree1, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i)).x, transform.TransformPoint(shape.spline.GetPosition(i)).y + 3), transform.rotation);
                    }else {
                        Instantiate(tree2, new Vector2(transform.TransformPoint(shape.spline.GetPosition(i)).x, transform.TransformPoint(shape.spline.GetPosition(i)).y + 3), transform.rotation);
                    }
                }
            }

            for(int i = 2; i < amountOfPoints + 2; i++) {
                shape.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
                shape.spline.SetLeftTangent(i, new Vector2(-2.5f, 0));
                shape.spline.SetRightTangent(i, new Vector2(2.5f, 0));
            }
        }
    }
}
