using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ULA : MonoBehaviour
{
    public Transform LLAPos;
    public static bool LLAIsattatched = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HingeJoint2D>() == null)
            if (collision.gameObject.tag == "LLA")
        {
            collision.gameObject.transform.position = LLAPos.position;
            collision.gameObject.transform.rotation = LLAPos.rotation;
            collision.gameObject.AddComponent<HingeJoint2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
            collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(0.1284766f, 1.791118f);
            collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(0.001822936f, -1.466433f);
            LLAIsattatched = true;
        }
    }
}
