using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damange : MonoBehaviour
{
    public PlayerHealth pHealth;
    public float damage;
   
   
   
    

   
    
   

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            pHealth.Health -=damage;
        }

    }

}