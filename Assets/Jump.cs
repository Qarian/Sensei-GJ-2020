using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private float jumpHeight = 10.0f;

    private Vector2 jumpDir= new Vector2(0,1);

    private Rigidbody2D rb;

    public KeyCode jumpKey;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey(jumpKey))
        {
            rb.velocity = jumpHeight * jumpDir;
        }
    }
}
