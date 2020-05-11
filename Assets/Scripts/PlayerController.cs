using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horzInput;
    public float jumpForce;

    private Rigidbody2D rb;
    private groundcheck groundcheck;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        groundcheck = GameObject.Find("groundcheck").GetComponent<groundcheck>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get the inputs
        horzInput = Input.GetAxis("Horizontal");

        //Move the player
        rb.velocity = new Vector2(Vector2.right.x * speed * horzInput * Time.deltaTime, rb.velocity.y);

        //Jump
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }

    public void jump()
    {
        if(groundcheck.grounded)
        {
            rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
        }
        
    }

}
