using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cinemachine : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 8f;
    public float acceleration = 12f;
    public float deceleration = 10f;

    [Header("Jumping")]
    public float jumpForce = 14f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    [Header("Dashing")]
    private bool canDash = true;
    private bool isDashing;
    private float dashingpower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;

    [SerializeField] private TrailRenderer tr;
    [SerializeField] private Animator animator;

  
    [Header("Wall Sliding")]
    public Transform wallCheck;
    public float wallCheckDistance = 0.5f;
    public LayerMask wallLayer;
    public float wallSlideSpeed = 2f;
    public Transform wallCheckLeft;
    private bool touchingRightWall;
    private bool touchingLeftWall;


    [Header("Wall Jumping")]
    public float wallJumpForce = 14f;
    public Vector2 wallJumpDirection = new Vector2(1f, 1.5f);
    private bool isWallSliding;
    private bool isTouchingWall;
    private bool isWallJumping;
  

    private Rigidbody2D rb;
    private float moveInput;
    private float currentVelocityX;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDashing) return;
    if (isWallJumping) return;

        moveInput = Input.GetAxisRaw("Horizontal");

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

    if(Input !=0){
            animator.SetBool("isRunning", true);
         }
         else{
             animator.SetBool("isRunning", false);
            }
     


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }


 
     
     
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }

        
         touchingRightWall = Physics2D.OverlapCircle(wallCheck.position, 0.2f, wallLayer);
         touchingLeftWall = Physics2D.OverlapCircle(wallCheckLeft.position, 0.2f, wallLayer);

        isTouchingWall = touchingRightWall || touchingLeftWall;
        
        if (isTouchingWall && !isGrounded && moveInput != 0)
        {
            isWallSliding = true;
        }
        else
        {
            isWallSliding = false;
        }

      
        if (Input.GetKeyDown(KeyCode.Space) && isWallSliding)
        {
            isWallJumping = true;
            Invoke(nameof(StopWallJump), 0.2f);
        }
    }

    void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }

        float targetSpeed = moveInput * moveSpeed;

        if (Mathf.Abs(moveInput) > 0.1f)
        {
            currentVelocityX = Mathf.Lerp(rb.linearVelocity.x, targetSpeed, acceleration * Time.fixedDeltaTime);
        }
        else
        {
            currentVelocityX = Mathf.Lerp(rb.linearVelocity.x, 0, deceleration * Time.fixedDeltaTime);
        }

        rb.linearVelocity = new Vector2(currentVelocityX, rb.linearVelocity.y);

        
        if (isWallSliding)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, Mathf.Clamp(rb.linearVelocity.y, -wallSlideSpeed, float.MaxValue));
        }

       
  if (isWallJumping)
    {
        float jumpDir = (moveInput > 0) ? -1 : 1;

        rb.linearVelocity = new Vector2(
            wallJumpDirection.x * jumpDir * wallJumpForce,
            wallJumpDirection.y * wallJumpForce
        );
    }


    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.linearVelocity = new Vector2(moveInput * dashingpower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;

      
    }

 
    
    private void StopWallJump()
    {
        isWallJumping = false;
    }
}
