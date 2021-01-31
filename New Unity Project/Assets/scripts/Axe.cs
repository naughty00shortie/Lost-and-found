using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public Transform holder;
    private bool isleft;

    private void Update()
    {
        holder.position = new Vector3(holder.position.x, holder.position.y-(1*Time.deltaTime), holder.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag!="Ground")
        {
            collision.gameObject.AddComponent<Rigidbody2D>();
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up.normalized * 10000);
        }


        
    }
}
