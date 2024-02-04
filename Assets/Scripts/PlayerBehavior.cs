using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public AudioSource jump;
    
    // Start is called before the first frame update
    Rigidbody2D rb;
    private bool cantJump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce( new Vector2(-20, 0)); 
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector2(20, 0));
        }

        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Floor")
        {
            print("onfloor");
            if (Input.GetKeyDown("space") || Input.GetKeyDown("w"))
            {
                print("jumped");
                jump.Play();
                rb.velocity = new Vector2(rb.velocity.x, 10);

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Floor")
        {
            
        }
    }

}
