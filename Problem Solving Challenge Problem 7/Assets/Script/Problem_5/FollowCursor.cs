using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    public Rigidbody2D rb;

    // Bola mengikuti kursor
    void FixedUpdate()
    {
        Vector2 follow = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, follow, 10 * Time.deltaTime);
    }

}
