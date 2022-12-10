using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public static int maxHealth = 10000;
    public static int currentHealth;
    public EnemyHealthBar healthBar;
    int minimaldamage = 100;
    int maximaldamage = 200;
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
        if (period > 0.5f)
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
