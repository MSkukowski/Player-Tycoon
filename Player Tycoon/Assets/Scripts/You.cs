using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

public class You : MonoBehaviour
{
    public static int maxHealth = 10000;
    public static int currentHealth;
    public HealthBar healthBar;
    int minimaldamage = 50;
    int maximaldamage = 150;
    public float period = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (period > 2)
        {
            currentHealth = TakeDamage();
            period = 0;
        }
        period += UnityEngine.Time.deltaTime;
        healthBar.SetHealth(currentHealth);


    }
    int TakeDamage()
    {
        int damage = Random.Range(minimaldamage, maximaldamage);
        currentHealth -= damage;
        return (currentHealth);
    }
}
