using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;
    private string playerID;
    public Player player;

    private BoxCollider2D coll;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LayerMask JumpableGround;
    [SerializeField] private AudioSource Jump;
    [SerializeField] private AudioSource Walk;
    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
        playerID = player.playerID.ToString();
        coll = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal" + playerID);

        if (Input.GetButtonDown("Jump" + playerID) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

       if(rb.velocity.magnitude > 2f && IsGrounded())
        {
            Walk.enabled = true;
        }
        else
        {
            Walk.enabled = false;
        }

        if (Input.GetButtonDown("Jump" + playerID) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, 13f);
            Jump.Play();
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f,180f,0f);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, JumpableGround);
    }
}