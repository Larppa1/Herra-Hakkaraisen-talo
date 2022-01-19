using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rigidbody;
    private Vector2 playerDirection;
    public int i = 0;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        if(Input.GetKey("up") && i == 0) {
            Quaternion current = transform.rotation;
            Quaternion target = Quaternion.Euler(new Vector3(0, 0, 50));
            transform.rotation = Quaternion.Slerp(current, target, 0.04f);
            i = 1;
        }else if(Input.GetKeyUp("up")) {
            Quaternion current = transform.rotation;
            Quaternion target = Quaternion.Euler(new Vector3(0, 0, -50));
            transform.rotation = Quaternion.Slerp(current, target, 0.04f);
            i = 0;
        }else if(Input.GetKey("down") && i == 0) {
            Quaternion current = transform.rotation;
            Quaternion target = Quaternion.Euler(new Vector3(0, 0, -50));
            transform.rotation = Quaternion.Slerp(current, target, 0.04f);
            i = 1;
        }else if(Input.GetKeyUp("down")) {
            Quaternion current = transform.rotation;
            Quaternion target = Quaternion.Euler(new Vector3(0, 0, 50));
            transform.rotation = Quaternion.Slerp(current, target, 0.04f);
            i = 0;
        }
    }

    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
