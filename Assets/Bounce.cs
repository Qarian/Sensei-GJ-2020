using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bounce : MonoBehaviour
{
    [SerializeField] private float bounceHeightMax = 15.0f;
    [SerializeField] private float bounceHeightMin = 5.0f;
    
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            _rb.velocity = Random.Range(bounceHeightMin, bounceHeightMax) * Vector2.up;
        }
    }
}
