using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        Push();
    }

    // Bola akan bergerak ke arah yang random dengan kecepatan yang konstan
    void Push(){
        float x = Random.Range(-100, 100);
        float y = Random.Range(-100, 100);
        rb2D.AddForce(new Vector2(x, y).normalized * 50);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            GameOver.Instance.GameOverRun();
        }
    }
}
