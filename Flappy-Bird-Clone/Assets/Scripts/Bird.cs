using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private float _jumoAmount = 40f;
    
    [SerializeField]
    private bool _canJump = true;

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
        if (transform.position.y > 45)
        {
            _canJump = false;
            _birdRigidBody2D.velocity = Vector2.up * 0;
        }
        else if (transform.position.y <=45)
        {
            _canJump = true;
        }
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && _canJump)
        {
            _birdRigidBody2D.velocity = Vector2.up * _jumoAmount;
            _startGame = true;
        }

        if (_startGame == true)
        {
            // transform.Translate(Vector3.right * Time.deltaTime * 50);
        }
        
        
    }
    

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Land") || other.gameObject.CompareTag("Pipe"))
        {
            Time.timeScale = 0;
        }
    }
}
