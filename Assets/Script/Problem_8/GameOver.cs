using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private static GameOver _instance = null;
    public static GameOver Instance 
    { 
        get 
        { 
            if (_instance == null) 
            { 
                _instance = FindObjectOfType<GameOver> (); 
            } 
            return _instance; 
        } 
    } 

    public GameObject gameOverPanel;
    public FollowCursor player;

    public void GameOverRun(){
        gameOverPanel.SetActive(true);
        player.enabled = false;
        Invoke("Restart", 3);
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
