using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;

    void Update()
    {
        float speed = Mathf.Abs(rb.linearVelocity.x);
        animator.SetFloat("speed", speed);
    }
}
