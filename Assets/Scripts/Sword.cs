using UnityEngine;

public class sworddmg : MonoBehaviour
{
    public Animator animator;
    public GameObject swordHitbox;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
    }

    public void EnableHitbox()
    {
        swordHitbox.SetActive(true);
    }

    public void DisableHitbox()
    {
        swordHitbox.SetActive(false);
    }
}
