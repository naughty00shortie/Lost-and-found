using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URA : MonoBehaviour
{
    public Transform LRAPos;
    public static bool LRAIsattatched = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HingeJoint2D>() == null)
            if (collision.gameObject.tag == "RLA")
        {
            collision.gameObject.transform.position = LRAPos.position;
            collision.gameObject.transform.rotation = LRAPos.rotation;
            collision.gameObject.AddComponent<HingeJoint2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(-0.04989126f, 1.592988f);
            collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(-0.02152937f, -1.306456f);
            LRAIsattatched = true;
        }
    }
}
