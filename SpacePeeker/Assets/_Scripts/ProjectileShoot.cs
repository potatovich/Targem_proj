using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.timeScale != 0)
        {
            Vector3 myVector = new Vector3(0.0f, 7.5f, 0.0f);
            GameObject rocket = Instantiate<GameObject>(projectilePrefab);
            rocket.transform.position = transform.position + myVector;
        }
    }
}
