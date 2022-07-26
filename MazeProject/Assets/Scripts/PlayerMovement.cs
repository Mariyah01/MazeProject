using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speed;

    [SerializeField] private Animator _animator;

    public int wallet;

    void Start()
    {

        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movement.z = 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement.z = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
        }

        if (movement == Vector3.zero)
        {
            _animator.SetBool("isMoving", false);
        }
        else
        {
            _animator.SetBool("isMoving", true);
            
        }
        GetComponent<Rigidbody>().velocity = movement * speed;

        
    }


}

