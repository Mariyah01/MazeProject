using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 offset = new Vector3(42, 300, -111);
    private float smoothTime = .25f;
    private Vector3 velocity = UnityEngine.Vector3.zero;
    [SerializeField] private Transform target;

    [SerializeField] private Camera _camera;
    [SerializeField] private CharacterController _characterController;
    void Start()
    {
        
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        var direction = GetMovement();
        var rot = _camera.transform.rotation.eulerAngles;

        rot.x = 0f; // Remove rotation on X axis or it can slow the character down because they are trying to walk into the ground.
        Quaternion q = Quaternion.Euler(rot);
        rot = q * direction;

        _characterController.Move(rot);
    }

    private Vector3 GetMovement()
    {
        var h = UnityEngine.Input.GetAxis("Horizontal");
        var v = UnityEngine.Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h,0,v);
        if(movement.magnitude>1f)
            movement.Normalize();
        return movement;

    }
    
    // Update is called once per frame
    /*void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }*/
}
