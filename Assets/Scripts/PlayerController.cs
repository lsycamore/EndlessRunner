using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //speed and jump force of player
    public float moveSpeed;
    public float jumpForce;

    //Sets the collision box
    private Rigidbody2D myRigidbody;

    //Makes player collide with ground
    public bool grounded;
    public LayerMask whatIsGround;

    //Instantiates collider
    private Collider2D myCollider;
    //Use this for initialisation

    private Animator myAnimator;

    //Code is run at the start of the game, retrieves needed components
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();

        myAnimator = GetComponent<Animator>();
    }

    //Update is called once per frame
    void Update()
    {
        //clarifies whether the player is touching the ground
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        //sets the character to only move forward
        myRigidbody.velocity = new Vector2(moveSpeed,myRigidbody.velocity.y);
        //Checks key presses to make the player jump
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded)
            { 
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
            }
        }

        //sets data for use in Unity
        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);

    }
}
