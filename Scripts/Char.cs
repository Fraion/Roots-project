using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    public Rigidbody2D rb;
    public int movespeed;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movespeed = 15;
    }

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatIsGround);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2 (-movespeed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2 (movespeed, rb.velocity.y);
        }
        
        if(Input.GetKey(KeyCode.Space) && onGround)
        {
            rb.velocity = new Vector2 (rb.velocity.x, 10);
        }
    }

    
}
