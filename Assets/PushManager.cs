using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushManager : MonoBehaviour
{
    float cooldown = 0.3f;
    float lastUsed = 0f;
    public GameObject push;

    void Start()
    {
        lastUsed = -cooldown;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ((Time.time - cooldown) > lastUsed))
        {
            Vector2 mousePositionCamera = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject instance = Instantiate(push, mousePositionCamera, push.transform.rotation);
            lastUsed = Time.time;
        }
    }
}
