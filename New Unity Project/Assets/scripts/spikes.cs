using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    public GameObject particle;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HingeJoint2D>() != null)
        {

            if (collision.gameObject.tag != "NotUsedParts")
            {
                Instantiate(particle, transform.position, transform.rotation);
                Destroy(collision.gameObject.GetComponent<HingeJoint2D>());
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(collision.gameObject.transform.up * 500);
                Head.isdead = true;
                if (collision.gameObject.tag == "Head")
                {
                    Body.HeadIsattatched = false;
                }
                if (collision.gameObject.tag == "RUA")
                {
                    Body.URAIsattatched = false;
                }
                if (collision.gameObject.tag == " LUA")
                {
                    Body.ULAIsattatched = false;
                }
                if (collision.gameObject.tag == " RUL")
                {
                    Body.URLIsattatched = false;
                }
                if (collision.gameObject.tag == "LUL")
                {
                    Body.ULLIsattatched = false;
                }




            }
            else
            {
                
            }



        }
    }
}
