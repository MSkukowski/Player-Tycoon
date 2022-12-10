using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
   
    public Image fill;
    public Slider slider;
    public Gradient gradient;
        
    public void SetMaxHealth(int health)
    {
        fill.color = gradient.Evaluate(1f);
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
