using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public float speed = 1;
    public float downUpDistance = 15f;
    public float chanceDirection = 0.1f;

    public GameObject asteroidPrefab;
    public float spawnTimer;
    public float spawnMax1 = 10;
    public float spawnMin1 = 5;
    


    void Start()
    {
        spawnTimer = Random.Range(spawnMin1, spawnMax1);
        Vector3 myVector = new Vector3(0f, 0f, 0f);
        GameObject rocket = Instantiate<GameObject>(asteroidPrefab);
        rocket.transform.position = transform.position + myVector;
    }

    void Update()
    {
        if (Time.timeScale != 0)
        {
            Vector3 pos = transform.position;
            pos.y += speed * Time.deltaTime;
            transform.position = pos;

            if (pos.y < -downUpDistance)
            {
                speed = Mathf.Abs(speed);
            }
            else if (pos.y > downUpDistance)
            {
                speed = -Mathf.Abs(speed);
            }

            spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0)
            {
                Vector3 myVector = new Vector3(0f, 0f, 0f);
                GameObject rocket = Instantiate<GameObject>(asteroidPrefab);
                rocket.transform.position = transform.position + myVector;
                spawnTimer = Random.Range(spawnMin1, spawnMax1);
            }
        }
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceDirection)
        {
            speed *= -1;
        }
    }
}