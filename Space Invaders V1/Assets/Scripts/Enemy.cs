using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    float MovTime = 0;
    int sideMov = 1;
    bool TouchWall = false;
    float SpeedCounter = 0;
    int Speed = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpeedCounter += Time.deltaTime;
    }


    void FixedUpdate()
    {

        MovTime += Time.deltaTime;

        if (SpeedCounter > 10f)
            Speed = 10;
        if(MovTime * Speed > 1 && TouchWall == false)
        {

            transform.position = new Vector2(transform.position.x + sideMov * .2f, transform.position.y);
            MovTime = 0;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.collider.name);
        if (collision.collider.name == "Right Wall")
        {
            print("if i'm here, they know i'm touching the wall");
            TouchWall = true;
            transform.position = new Vector2(transform.position.x, transform.position.y - .5f);
            sideMov = -1;
            TouchWall = false;
        }
        else if (collision.collider.name == "Left Wall")
        {

            TouchWall = true;
            transform.position = new Vector2(transform.position.x, transform.position.y - .5f);
            sideMov = 1;
            TouchWall = false;

        }
    }
 }
