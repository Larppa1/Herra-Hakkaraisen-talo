using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

namespace TIKO4A2021 {
    public class TerrainController : MonoBehaviour {
        public SpriteShapeController shape;
        public int scale;

        void Start() {
            shape = GetComponent<SpriteShapeController>();
            int amountOfPoints = scale / 6;
            float distanceBetweenPoints = (float)scale / (float)amountOfPoints;

            shape.spline.SetPosition(2, shape.spline.GetPosition(2) + Vector3.right * scale);
            shape.spline.SetPosition(3, shape.spline.GetPosition(3) + Vector3.right * scale);

            for(int i = 0; i < amountOfPoints; i++) {
                float xPos = shape.spline.GetPosition(i + 1).x + distanceBetweenPoints;
                shape.spline.InsertPointAt(i + 2, new Vector2(xPos, 12 * Mathf.PerlinNoise(i * Random.Range(5.0f, 14.0f), 0)));
            }

            for(int i = 2; i < amountOfPoints + 2; i++) {
                shape.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
                shape.spline.SetLeftTangent(i, new Vector2(-2.5f, 0));
                shape.spline.SetRightTangent(i, new Vector2(2.5f, 0));
            }
        }
    }
}
