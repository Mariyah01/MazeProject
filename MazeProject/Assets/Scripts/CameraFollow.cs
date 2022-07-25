using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 offset = new Vector3(-45, 300, -75);
    private float smoothTime = .25f;
    private Vector3 velocity = UnityEngine.Vector3.zero;
    [SerializeField] private Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
