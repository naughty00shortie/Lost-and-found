using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tongue : MonoBehaviour
{
    public Transform tonguePos;

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!Head.isdead)
        if (collision.gameObject.tag == "Head")
        {

            transform.position = tonguePos.position;
            transform.rotation = tonguePos.rotation;
            collision.gameObject.AddComponent<HingeJoint2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(0.1701992f, -2.530051f);
            collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(-0.6327435f, -0.04106998f);
            collision.gameObject.GetComponent<HingeJoint2D>().useLimits = true;

        }
    }
}
