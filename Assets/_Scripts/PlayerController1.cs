using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float moveSpeed = 5;
    public float hInput;
    public int min_x;

    void Update()
    {
        if (this.transform.position.x < min_x)
            this.transform.position = new Vector3(min_x, this.transform.position.y, this.transform.position.z);

        hInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);
    }
}
