using UnityEngine;

public class SwordDamage : MonoBehaviour
{
    public float damage = 25f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            EnemyHealth hp = other.GetComponent<EnemyHealth>();
            if (hp != null)
            {
                hp.TakeDamage(damage);
            }
        }
    }
}
