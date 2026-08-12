using UnityEngine;

public class Sword : MonoBehaviour
{
    public float damageAmount = 25f;
    public float attackCooldown = 0.5f;
    private float lastAttackTime;
    private Transform playerHand;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerHand = player.transform.Find("Hand");
            if (playerHand != null)
            {
                transform.SetParent(playerHand);
                transform.localPosition = Vector3.zero;
                transform.localRotation = Quaternion.identity;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && Time.time > lastAttackTime + attackCooldown)
        {
            EnemyHealth enemy = other.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damageAmount);
                lastAttackTime = Time.time;
            }
        }
    }
}
