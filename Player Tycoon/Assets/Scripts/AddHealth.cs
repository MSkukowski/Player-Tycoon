using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddHealth : MonoBehaviour
{
    
    public void Funkcja()
    {
        You.currentHealth = You.currentHealth + 350;
        if(You.currentHealth>You.maxHealth)
        {
            You.currentHealth = You.maxHealth;
        }
    }
    
}
