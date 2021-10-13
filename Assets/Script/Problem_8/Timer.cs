using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    float currentTime;
    public float startingTime = 20f;

    
    void Start()
    {
        currentTime = startingTime;
        timeText.text = currentTime.ToString();
    }

    void Update()
    {
        if(currentTime > 0)
            currentTime -= Time.deltaTime;
        else{
            currentTime = 0;
            GameOver.Instance.GameOverRun();
        }
            
    
        timeText.text = currentTime.ToString("0");
    }
}
