using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject ball;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (ball.transform.position.y > transform.position.y)
        {
            rb.MovePosition(rb.position + new Vector2(0, 1) * speed * Time.deltaTime);
        }
        else if (ball.transform.position.y < transform.position.y)
        {
            rb.MovePosition(rb.position + new Vector2(0, -1) * speed * Time.deltaTime);
        }
    }
}
