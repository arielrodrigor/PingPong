using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveY = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + new Vector2(0, moveY) * speed * Time.deltaTime);
    }
}
