using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<HingeJoint2D>() != null)
        {

           if (collision.gameObject.tag!="NotUsedParts")
            {
                Destroy(collision.gameObject.GetComponent<HingeJoint2D>());
                collision.gameObject.GetComponent<Rigidbody2D>().AddForce(collision.gameObject.transform.up * 500);
                Head.isdead = true;
            }

        }
    }
}
