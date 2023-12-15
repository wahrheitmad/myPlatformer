using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpace : MonoBehaviour
{
    Vector2 startPos;

    private void Start()
    {
        startPos = transform.position;
    }
    void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag("DieSpace"))
        {
            transform.position = startPos;
        }
    }
}
