using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource land;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnMouseDown()
    {
        Destroy(GetComponent<Rigidbody2D>());
        land.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider == GameObject.Find("Floor").GetComponent<BoxCollider2D>())
        {
            Destroy(gameObject);
        }
    }
}
