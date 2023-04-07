using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private Player player;
    private int playerID;
    private CapsuleCollider2D coll;
    private Rigidbody2D rb;
    private LayerMask JumpableGround;
    private AudioSource Jump_sound;
    private AudioSource Walk_sound;
    //[SerializeField] private LayerMask groundLayer;    // not used?
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;
    private Animator animator;

    void Start()
    {
        JumpableGround = LayerMask.GetMask("Ground");
        rb = GetComponent<Rigidbody2D>();                   // automatically gets various components
        coll = GetComponent<CapsuleCollider2D>();
        Walk_sound = GetComponents<AudioSource>()[0];
        Jump_sound = GetComponents<AudioSource>()[1];
        player = GetComponent<Player>();
        playerID = player.playerID;
        animator = GetComponent<Animator>();
        
    }
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal" + playerID); 
        

        if (Input.GetButtonDown("Jump" + playerID.ToString()) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animator.Play("Black_Jump",0);          // play the jumping animation
            Jump_sound.Play();              // play the jumping sound
        }
       if(IsGrounded() && Input.GetButtonDown("Horizontal" + playerID.ToString()))   // if on ground and moving, play the walking sound, else stop playing it
        {
            Walk_sound.enabled = true;
        }
        else
        {
            Walk_sound.enabled = false;
      
        }

        Flip(); // flip the sprite if needed
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);   // move the player object according to the values of horizontal and speed
        if (IsGrounded()) {
            animator.SetFloat("xinput", Mathf.Abs(rb.velocity.x));      // set the float value inside the animation controller 
        
        }
        
    }
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f,180f,0f);
        }
    }
    //rb.velocity.magnitude > 2f &&
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, JumpableGround);
    }

}
