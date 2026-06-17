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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      maxHealth = Health;
    }

    // Update is called once per frame
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

}
}
