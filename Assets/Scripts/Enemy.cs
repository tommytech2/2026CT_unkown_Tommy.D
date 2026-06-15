using UnityEngine;

public class Enemy2D : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 2f;
    public Transform pointA;
    public Transform pointB;

    private Transform currentTarget;

    [Header("Player Detection")]
    public Transform player;
    public float chaseRange = 5f;

    private SpriteRenderer sr;

    private void Start()
    {
        currentTarget = pointA;
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer < chaseRange)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
        }
    }

    private void Patrol()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            currentTarget.position,
            speed * Time.deltaTime
        );

        // Flip sprite based on direction
        if (currentTarget.position.x > transform.position.x)
            sr.flipX = false;
        else
            sr.flipX = true;

        if (Vector2.Distance(transform.position, currentTarget.position) < 0.1f)
        {
            currentTarget = (currentTarget == pointA) ? pointB : pointA;
        }
    }

    private void ChasePlayer()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            player.position,
            speed * Time.deltaTime
        );

        // Flip sprite toward player
        if (player.position.x > transform.position.x)
            sr.flipX = false;
        else
            sr.flipX = true;
    }
}
