using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float moveSpeed;
    public static float bottomY = -100f;

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
