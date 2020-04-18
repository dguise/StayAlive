using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float deathTime = 0.4f;
    float scale = 2;
    float magnitude = 300f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, deathTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localScale += new Vector3(0.1f * scale, 0.1f * scale, 0.1f);
    }


    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            var pos = transform.position;
            var pos_other = collider.transform.position;
            var rb_other= collider.GetComponent<Rigidbody2D>();
            var force = (pos_other - pos) * magnitude;
            rb_other.AddForce(force);
        }
    }

}
