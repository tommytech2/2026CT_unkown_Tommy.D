using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;





public class PlayerHealth : MonoBehaviour
{
    public float Health;
    public float maxHealth;
    public Image healthBar;
    void Start()
    {
      maxHealth = Health;
    }


   
    void Update()
     {
        if (Health <= 0)
        {
            GameOver();
        }
    

    
    
    {
        healthBar.fillAmount = Mathf.Clamp(Health/maxHealth, 0, 1 );
    }

 void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


[SerializeField] Animator animator;

     void TakeDamage(float amount)
    {
        Health -= amount;

        if (Health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetTrigger("Death");

        
        GetComponent<PlayerMovement>().enabled = false;

    
        GetComponent<Collider2D>().enabled = false;

        


    }
     }
}

