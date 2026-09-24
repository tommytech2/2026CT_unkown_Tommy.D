using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public float attackRange = 1f;
    public float attackDamage = 25f;
    public LayerMask enemyLayer;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left click attack
        {
            animator.SetTrigger("Attack");
            DoAttack();
        }
    }

    void DoAttack()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, attackRange, enemyLayer);

        foreach (Collider2D enemy in hits)
        {
            EnemyHealth hp = enemy.GetComponent<EnemyHealth>();
            if (hp != null)
            {
                hp.TakeDamage(attackDamage);
            }
        }
    }
}
