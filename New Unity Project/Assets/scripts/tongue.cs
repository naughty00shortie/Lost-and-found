using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tongue : MonoBehaviour
{
    public Transform tonguePos;
    public Camera cam;
    public LineRenderer _lineRenderer;
    public DistanceJoint2D _disttanceJoint;

    Rigidbody2D rb2D;
  //  public float floatHeight;


    Vector2 mousepos;
    public static bool isattatched = false;
    public static bool isattatchedToGround = false;
    public static bool isgrappled = false;

    void Update()
    {


        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (isattatched)
        {


            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Vector2 _mousePos = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
                _lineRenderer.SetPosition(0, mousepos);
                _lineRenderer.SetPosition(1, transform.position);
                _disttanceJoint.connectedAnchor = cam.ScreenToWorldPoint(Input.mousePosition);
                _disttanceJoint.enabled = true;
                _lineRenderer.enabled = true;
                isgrappled = true;
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                _disttanceJoint.enabled = false;
                _lineRenderer.enabled = false;
                isgrappled = false;
            }
        }
            if (_disttanceJoint.enabled)
            {
                _lineRenderer.SetPosition(1, transform.position);
            }
        


      
    }

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if (isattatched &&!isgrappled)
        {
            Vector3 lookDir = mousepos - GetComponent<Rigidbody2D>().position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
            GetComponent<Rigidbody2D>().rotation = angle;
        }




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
                isattatched = true;

            }
      }
              

                

            

}
