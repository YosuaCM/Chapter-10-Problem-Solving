using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject ItemPrefab;
    float x, y;
    public Vector2 radius;
    public float minbox;
    public float maxbox;
    float spawn;

    void Start()
    {
        objectspawn(minbox, maxbox);
    }

    public void objectspawn(float minbox, float maxbox)
    {
        spawn = Random.Range(minbox, maxbox);
        Vector2 pos;

        for (int i = 0; i < spawn; i++)
        {
            x = Random.Range(-radius.x, radius.x);
            y = Random.Range(-radius.y, radius.y);

            pos = new Vector2(x, y);
            GameObject Spawnresult = Instantiate(ItemPrefab, pos, transform.rotation);
        }
    }
}