using UnityEngine;

public class CursorBall : MonoBehaviour
{
    [Header("Follow Settings")]
    public float followSpeed = 10f;

    [Header("Damage Settings")]
    public int damageAmount = 1;
    public float damageCooldown = 0.5f;

    private float lastDamageTime;

    void Update()
    {
     e
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

      
        transform.position = Vector2.Lerp(transform.position, mousePos, followSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Damage enemies on contact
        if (other.CompareTag("Enemy") && Time.time > lastDamageTime + damageCooldown)
        {
            EnemyHealth enemy = other.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damageAmount);
                lastDamageTime = Time.time;
            }
        }
    }
}
