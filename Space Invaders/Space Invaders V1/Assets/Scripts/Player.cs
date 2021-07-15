using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody2D body;


    // Start is called before the first frame update
    void Start()
    {

        body = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.name);
       /* if (collision.collider.tag == "Enemy")
        {

        }*/
    }

    void FixedUpdate()
    {

        float move = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(move * speed, body.velocity.y);

    }
}
