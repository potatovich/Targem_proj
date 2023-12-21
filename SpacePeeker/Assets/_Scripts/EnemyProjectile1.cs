using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile1 : MonoBehaviour
{
    public float moveSpeed;
    public static float bottomZ = -100f;

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (transform.position.y < bottomZ)
        {
            Destroy(this.gameObject);
        }
    }
}
