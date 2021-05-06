using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool moveRight = false;
    void Update()
    {
        Vector2 pos = transform.localPosition;

        if (moveRight)
        {
            pos.x += Vector2.right.x * moveSpeed * Time.deltaTime;

            if (pos.x >= 10)
            {
                pos.x = -10;
            }
        }
        else
        {
            pos.x += Vector2.left.x * moveSpeed * Time.deltaTime;

            if (pos.x <= -10)
            {
                pos.x = 10;
            }
        }
        transform.localPosition = pos;
    }
}
