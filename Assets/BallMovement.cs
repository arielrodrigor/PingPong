using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, speed);
    }

     public ScoreManager scoreManager;
    // Asumiendo que tienes los bordes marcados con tags "Left" y "Right"
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Left")
        {
            scoreManager.AIScores();
        }
        else if (collision.gameObject.tag == "Right")
        {
            scoreManager.PlayerScores();
        }
    }
}
