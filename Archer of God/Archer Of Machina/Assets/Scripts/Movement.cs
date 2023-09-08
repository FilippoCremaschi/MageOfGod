using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 200f;
    public float horizontalMove = 0f;
    Rigidbody2D rb;
    private bool facingRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2 (horizontalMove * speed * Time.fixedDeltaTime, rb.velocity.y);
        if(horizontalMove > 0 && !facingRight)
        {
            flip();
        }
        if (horizontalMove < 0 && facingRight)
        {
            flip();
        }
        if(horizontalMove == 0 && !facingRight)
        {
            flip();
        }

    }

    void flip()
    {
        facingRight = !facingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
