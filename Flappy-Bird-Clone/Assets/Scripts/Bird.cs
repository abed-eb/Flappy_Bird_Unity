using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private float _jumoAmount = 100f;

    [SerializeField] private Rigidbody2D _birdRigidBody2D;
    
    [SerializeField]
    private bool _startGame = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        _birdRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            _startGame = true;
        }

        if (_startGame == true)
        {
            // _birdRigidBody2D.velocity = Vector2.right * Time.deltaTime;
        }
        
        
    }

    private void Jump()
    {
        _birdRigidBody2D.velocity = Vector2.up * _jumoAmount;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
