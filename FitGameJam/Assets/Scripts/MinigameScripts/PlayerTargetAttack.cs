using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTargetAttack : MonoBehaviour
{
    public GameObject RetryButton, MainMenuButton;
    void start()
    {
        
    }
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boss")) 
        {
            RetryButton.SetActive(true);
            MainMenuButton.SetActive(true);
        }
    }
    
}
