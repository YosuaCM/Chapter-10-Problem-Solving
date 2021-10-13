using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Untuk menentukan kecepatan pergerakan bola
    public float speed;
    public Rigidbody2D rb;

    Vector2 move;

    void Update()
    {
        InputProcess();
    }

    void FixedUpdate()
    {
        moveball();
    }

    void InputProcess()
    {
        float moveY = Input.GetAxisRaw("Vertical");
        float movex = Input.GetAxisRaw("Horizontal");

        move = new Vector2(movex, moveY).normalized;
    }

    void moveball()
    {
        rb.velocity = new Vector2(move.x * speed, move.y * speed);
    }
}
