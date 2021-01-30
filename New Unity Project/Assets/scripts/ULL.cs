using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ULL : MonoBehaviour
{
    public Transform LLLPos;
    public static bool LLLIsattatched = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HingeJoint2D>() == null) 
        if (collision.gameObject.tag == "LLL")
        {
            collision.gameObject.transform.position = LLLPos.position;
            collision.gameObject.transform.rotation = LLLPos.rotation;
            collision.gameObject.AddComponent<HingeJoint2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(-0.9437619f, 2.041779f);
            collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(-0.009426925f, -1.40008f);
            LLLIsattatched = true;
        }

    }
}
