using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float attackRange = 1.5f;
    public float detectionRange = 6f;
    public Transform player;
    public Animator animator;

    private Rigidbody2D rb;
    private bool isAttacking;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= attackRange)
        {
            rb.linearVelocity = Vector2.zero;
            animator.SetBool("Run", false);
            animator.SetTrigger("Attack");
            isAttacking = true;
        }
        else if (distance <= detectionRange && !isAttacking)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.linearVelocity = new Vector2(direction.x * moveSpeed, rb.linearVelocity.y);
            animator.SetBool("Run", true);

            if (direction.x > 0)
                transform.localScale = new Vector3(1, 1, 1);
            else
                transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
            animator.SetBool("Run", false);
            animator.SetTrigger("Idle");
            isAttacking = false;
        }
    }

    public void EndAttack()
    {
        isAttacking = false;
    }
}
