using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float hInput;
    public int max_x;

    void Update()
    {
        if (this.transform.position.x > max_x)
            this.transform.position = new Vector3(max_x, this.transform.position.y, this.transform.position.z);

        hInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);
    }
}
