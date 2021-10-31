using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGenerate : MonoBehaviour
{
    public GameObject Box;
    public float SpawnRate = 0f;
    public float nextSpawn = 0f;
    float randomX;
    int randomY;
    private float[] linepos = { 3.85f, 2.42f, 2.13f, 1.51f, -3.30f };
    Vector2 whereToSpawn;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            randomX = Random.Range(-6f, 6f);
            randomY = Random.Range(0, linepos.Length);
            whereToSpawn = new Vector2(randomX, linepos[randomY]);
            Instantiate(Box, whereToSpawn, Quaternion.identity);
            nextSpawn = Time.time + SpawnRate;
            Debug.Log(Time.time + SpawnRate);
        }
    }
}
