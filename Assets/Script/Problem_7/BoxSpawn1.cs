using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        this.gameObject.SetActive(false); 
        ScoreController.Instance.AddScore(); // tambah score
    }
}
