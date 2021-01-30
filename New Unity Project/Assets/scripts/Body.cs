using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public Transform HeadPos;
    public Transform URAPos;
    public Transform ULAPos;
    public Transform URLPos;
    public Transform ULLPos;
    public static bool HeadIsattatched = false;
    public static bool URAIsattatched = false;
    public static bool ULAIsattatched = false;
    public static bool URLIsattatched = false;
    public static bool ULLIsattatched = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!Head.isdead)
            if (GetComponent<HingeJoint2D>() == null)
            {

                if (collision.gameObject.tag == "Head")
                {

                    collision.gameObject.transform.position = HeadPos.position;
                    collision.gameObject.transform.rotation = HeadPos.rotation;
                    gameObject.AddComponent<HingeJoint2D>();
                    GetComponent<HingeJoint2D>().connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
                    GetComponent<HingeJoint2D>().anchor = new Vector2(-0.6f, 4.346376f);
                    GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(-0.7192575f, -3.117082f);
                    HingeJoint hinge = GetComponent<HingeJoint>();
                    JointLimits limits = hinge.limits;
                    limits.min = 233.35f;
                    limits.bounciness = 0;
                    limits.bounceMinVelocity = 0;
                    limits.max = 306.887f;
                    hinge.limits = limits;
                    hinge.useLimits = true;
                    HeadIsattatched = true;


                }
            }
        if (collision.gameObject.GetComponent<HingeJoint2D>() == null)
        {



            if (collision.gameObject.tag == "RUA")
            {
                collision.gameObject.transform.position = URAPos.position;
                collision.gameObject.transform.rotation = URAPos.rotation;
                collision.gameObject.AddComponent<HingeJoint2D>();
                collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
                collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(-0.0659151f, 1.394553f);
                collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(-2.762311f, 3.137876f);
                URAIsattatched = true;
            }

            if (collision.gameObject.tag == "LUA")
            {
                collision.gameObject.transform.position = ULAPos.position;
                collision.gameObject.transform.rotation = ULAPos.rotation;
                collision.gameObject.AddComponent<HingeJoint2D>();
                collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
                collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(0.1819144f, 1.498005f);
                collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(1.602995f, 3.680263f);
                ULAIsattatched = true;
            }

            if (collision.gameObject.tag == "LUL")
            {
                collision.gameObject.transform.position = ULLPos.position;
                collision.gameObject.transform.rotation = ULLPos.rotation;
                collision.gameObject.AddComponent<HingeJoint2D>();
                collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
                collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(-0.08868954f, 1.176223f);
                collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(2.392935f, -4.012051f);
                ULLIsattatched = true;
            }

            if (collision.gameObject.tag == "RUL")
            {
                collision.gameObject.transform.position = URLPos.position;
                collision.gameObject.transform.rotation = URAPos.rotation;
                collision.gameObject.AddComponent<HingeJoint2D>();
                collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
                collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(0.2615004f, 1.537661f);
                collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(-1.546074f, -4.073785f);
                URLIsattatched = true;
            }
        }
            
    }
}
