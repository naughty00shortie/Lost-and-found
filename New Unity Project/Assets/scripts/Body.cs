using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Body : MonoBehaviour
{
    public Transform HeadPos;
    public Transform URAPos;
    public Transform ULAPos;
    public Transform URLPos;
    public Transform ULLPos;
    public GameObject _tongue;
    public GameObject LRA;
    public GameObject LRL;
    public GameObject LLA;
    public GameObject LLL;
    public Transform LRAPos;
    public Transform LRLPos;
    public Transform LLAPos;
    public Transform LLLPos;
    public Transform tonguepos;
    public static bool HeadIsattatched = false;
    public static bool URAIsattatched = false;
    public static bool ULAIsattatched = false;
    public static bool URLIsattatched = false;
    public static bool ULLIsattatched = false;

    public Sprite yes;
    public Sprite no;
    public Image _Tongue;
    public Image body;
    public Image LeftArm;
    public Image RightArm;
    public Image LeftLeg;
    public Image RightLeg;

    private void Update()
    {
        if (tongue.isattatched)
        {
            _Tongue.sprite = yes;
        }
        if (!HeadIsattatched)
        {
            body.sprite = no;
            LeftArm.sprite = no;
            RightArm.sprite = no;
            LeftLeg.sprite = no;
            RightLeg.sprite = no;

        }
        if (!URAIsattatched)
        {
            RightArm.sprite = no;
        }
        if (!ULAIsattatched)
        {
           LeftArm.sprite = no;
        }
        if (!URLIsattatched)
        {
            RightLeg.sprite = no;
        }
        if (!ULLIsattatched)
        {
           LeftLeg.sprite = no;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!Head.isdead)
            if (GetComponent<HingeJoint2D>() == null)
            {

                if (collision.gameObject.tag == "Head")
                {

                    collision.gameObject.transform.position = HeadPos.position;
                    collision.gameObject.transform.rotation = HeadPos.rotation;
                    _tongue.transform.position = tonguepos.position;
                    _tongue.transform.rotation = tonguepos.rotation;

                    gameObject.AddComponent<HingeJoint2D>();
                    GetComponent<HingeJoint2D>().connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
                    GetComponent<HingeJoint2D>().anchor = new Vector2(-0.6f, 4.346376f);
                    GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(-0.7192575f, -3.117082f);
                    HingeJoint hinge = GetComponent<HingeJoint>();
                    HeadIsattatched = true;
                    body.sprite = yes;



                }
            }
        if (!Head.isdead)
            if (collision.gameObject.GetComponent<HingeJoint2D>() == null)
            {



                if (collision.gameObject.tag == "RUA")
                {
                    collision.gameObject.transform.position = URAPos.position;
                    collision.gameObject.transform.rotation = URAPos.rotation;
                    LRA.transform.position = LRAPos.position;
                    LRA.transform.rotation = LRAPos.rotation;
                    collision.gameObject.AddComponent<HingeJoint2D>();
                    collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
                    collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(-0.0659151f, 1.394553f);
                    collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(-2.762311f, 3.137876f);
                    URAIsattatched = true;
                    RightArm.sprite = yes;
                }

                if (collision.gameObject.tag == "LUA")
                {
                    collision.gameObject.transform.position = ULAPos.position;
                    collision.gameObject.transform.rotation = ULAPos.rotation;
                    LLA.transform.position = LLAPos.position;
                    LLA.transform.rotation = LLAPos.rotation;
                    collision.gameObject.AddComponent<HingeJoint2D>();
                    collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
                    collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(0.1819144f, 1.498005f);
                    collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(1.602995f, 3.680263f);
                    ULAIsattatched = true;
                    LeftArm.sprite = yes;
                }

                if (collision.gameObject.tag == "LUL")
                {
                    collision.gameObject.transform.position = ULLPos.position;
                    collision.gameObject.transform.rotation = ULLPos.rotation;
                    LLL.transform.position = LLLPos.position;
                    LLL.transform.rotation = LLLPos.rotation;
                    collision.gameObject.AddComponent<HingeJoint2D>();
                    collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
                    collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(-0.08868954f, 1.176223f);
                    collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(2.392935f, -4.012051f);
                    ULLIsattatched = true;
                    LeftLeg.sprite = yes;
                }

                if (collision.gameObject.tag == "RUL")
                {
                    collision.gameObject.transform.position = URLPos.position;
                    collision.gameObject.transform.rotation = URAPos.rotation;
                    LRL.transform.position = LRLPos.position;
                    LRL.transform.rotation = LRLPos.rotation;
                    collision.gameObject.AddComponent<HingeJoint2D>();
                    collision.gameObject.GetComponent<HingeJoint2D>().connectedBody = gameObject.GetComponent<Rigidbody2D>();
                    collision.gameObject.GetComponent<HingeJoint2D>().anchor = new Vector2(0.2615004f, 1.537661f);
                    collision.gameObject.GetComponent<HingeJoint2D>().connectedAnchor = new Vector2(-1.546074f, -4.073785f);
                    URLIsattatched = true;
                    RightLeg.sprite = yes;
                }
            }
            
    }
}
