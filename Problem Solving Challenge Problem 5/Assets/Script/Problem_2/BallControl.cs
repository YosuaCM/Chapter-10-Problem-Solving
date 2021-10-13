using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Rigidbody 2D for ball
    private Rigidbody2D rigidbody2d;

    // Bola bergerak secara random dan kecepatan yang konstan
    void PushBall()
    {
        float a = Random.Range(-100, 100);
        float b = Random.Range(-100, 100);

        rigidbody2d.AddForce(new Vector2(a, b).normalized * 50);  
    }

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        PushBall();
    }








}
