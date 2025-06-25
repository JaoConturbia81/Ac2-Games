using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public GameManager gameManager;  
    public ParticleSystem efeito;    
    private bool foiColetado = false; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (foiColetado) return;  
         
            PlayerMovement playerMovement = collision.GetComponent<PlayerMovement>();
            if (playerMovement != null)
            {
                playerMovement.runSpeed *= 1.5f;  
            }
            
            gameManager.AddPoints(1);
            
            Instantiate(efeito, transform.position, Quaternion.identity);
           
            Destroy(gameObject);
       
            foiColetado = true;
        }
    }
}
