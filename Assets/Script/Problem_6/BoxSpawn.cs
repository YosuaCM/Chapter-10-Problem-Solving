using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        this.gameObject.SetActive(false); // disable gameobject
    }
}
