using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{
    public Transform LRLPos;
    public static bool LRLIsattatched = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HingeJoint2D>() == null)
            if (collision.gameObject.tag == "RLL")
        {
            collision.gameObject.transform.position = LRLPos.position;
            collision.gameObject.transform.rotation = LRLPos.rotation;
            collision.gameObject.AddComponent<HingeJoint2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(1.012013f, 2.071264f);
            collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(0.05544559f, -1.333103f);
            LRLIsattatched = true;
        }
    }
}
