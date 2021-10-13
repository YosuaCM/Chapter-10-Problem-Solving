using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            this.gameObject.SetActive(false); 
            Invoke("SpawnRandom", 3);
            ScoreController.Instance.AddScore(); // tambah score
        }
        
    }

    private void SpawnRandom(){
        float randomX, randomY;
        Vector3 newPos;
        bool spawned = false;
        GameObject ball = GameObject.FindGameObjectWithTag("Player");

        // akan terus mencari posisi baru jika box terlalu dekat dengan bola
        while(!spawned){
            randomX = Random.Range(-8, 8);
            randomY = Random.Range(-4, 4);
            newPos = new Vector3(randomX, randomY, 0f);
            this.transform.position = newPos;
            if((transform.position - ball.transform.position).magnitude < 2){
                continue;
            }else{
                spawned = true;
                this.gameObject.SetActive(true);
            }
        }
    }
}
