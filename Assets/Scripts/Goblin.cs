using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goblin : MonoBehaviour
{
    public float goblinSpeed;
    private Rigidbody2D rigidbody;
    private Vector2 goblinDirection;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        goblinDirection = new Vector2(-1, 0).normalized;
    }

    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(goblinDirection.x * goblinSpeed, 0);
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Dragon")
        {
            goblinSpeed = 0;
        }
    }
}
