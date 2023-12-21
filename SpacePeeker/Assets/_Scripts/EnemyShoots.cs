using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoots : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float spawnTimer;
    public float spawnMax = 10;
    public float spawnMin = 5;

    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    private void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Vector3 myVector = new Vector3(0f, -8f, 0f);
            GameObject rocket = Instantiate<GameObject>(projectilePrefab);
            rocket.transform.position = transform.position + myVector;
            spawnTimer = Random.Range(spawnMin, spawnMax);
        }
    }
}
