using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    private bool facingRight = true;

    Animator anim;

    Vector3 pos, velocity;

    private void Awake()
    {

    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        velocity = (transform.position - pos) / Time.deltaTime;
    }
    void Update()
    {
        Move();

    }

    void Move()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
            anim.SetBool("Walk", true);
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
            anim.SetBool("Walk", true);
        }
        if (Input.GetKey("d"))
        {
            anim.SetBool("Walk", true);
            pos.x += speed * Time.deltaTime;
            if (!facingRight)
            {
                Flip();
                facingRight = true;
            }
        }
        if (Input.GetKey("a"))
        {
            anim.SetBool("Walk", true);
            pos.x -= speed * Time.deltaTime;
            if (facingRight)
            {
                Flip();
                facingRight = false;
            }
                
        }
        if(Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d") || Input.GetKeyUp("w"))
            anim.SetBool("Walk", false);


        transform.position = pos;

    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;
    }
}

