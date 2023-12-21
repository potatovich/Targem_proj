using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float asteroidSpeed;
    public GameObject projectilePrefab;
    public static float rightX = 90f;


    void Update()
    {
        transform.Translate(Vector3.forward * asteroidSpeed * Time.deltaTime);

        if (transform.position.x > rightX)
        {
            Destroy(this.gameObject);
        }
    }
}
