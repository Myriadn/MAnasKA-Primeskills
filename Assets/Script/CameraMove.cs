using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float speed = 5.0f;
    public bool canMove = false; // Flag untuk mengizinkan pergerakan

    void Update()
    {
        if (canMove) // Hanya bergerak jika canMove = true
        {
            transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
    }
}
