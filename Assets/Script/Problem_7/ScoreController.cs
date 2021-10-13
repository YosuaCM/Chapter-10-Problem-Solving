using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private static ScoreController _instance = null;
    public static ScoreController Instance 
    { 
        get 
        { 
            if (_instance == null) 
            { 
                _instance = FindObjectOfType<ScoreController> (); 
            } 
            return _instance; 
        } 
    } 

    public Text scoree;
    private int score = 0 ;

    private void Start() {
        scoree.text = $"Score : {score}";
    }

    public void AddScore(){
        score++;
        scoree.text = $"Score : {score}";
    }
    
}
