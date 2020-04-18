using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform target;
    Camera camera;
    public float maxLen = 10f;
    float smoothSpeed = 0.5f;

    void Start()
    {
        camera = Camera.main;
    }

    void FixedUpdate()
    {

        if (target)
        {
            var distance = target.position - transform.position;
            distance.z = 0;

            if (distance.magnitude > maxLen) {
                var new_pos = distance.normalized * (distance.magnitude - maxLen);
                var deciredPos = transform.position + new_pos;
                transform.position = Vector3.Lerp(transform.position, deciredPos, smoothSpeed);
                Debug.Log(new_pos);
            }
        }
    }
}
