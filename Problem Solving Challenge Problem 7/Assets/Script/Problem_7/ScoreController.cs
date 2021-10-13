using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoree;
    private int score = 0 ;

    
    void Start()
    {
        scoree.text = "Score : " + score;    
    }

    private void OnTriggerEnter2D(Collider2D box)
    {
        if (box.tag == "touchbox")
        {
            score++;
            Destroy(box.gameObject);
            scoree.text = "Score : " + score;
        }
    }
    
}
