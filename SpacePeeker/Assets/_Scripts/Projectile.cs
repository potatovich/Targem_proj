using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    public static float topY = 60f;
    public static float topZ = 60f;

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.position.y > topY || transform.position.y > topZ)
        {
            Destroy(this.gameObject);
        }
    }
}
