using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //public int health=1000;
    //int minimaldamage=50;
    //int maximaldamage=150;
    //public GameObject HPBar;
    //public Slider sliderHP;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    sliderHP = HPBar.GetComponent<Slider>();
    //    sliderHP.value = health;
    //    sliderHP.maxValue = health;

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    MinusHealth();
    //}
    public Slider slider;
    //public int health = 10000;
    //int minimaldamage = 50;
    //int maximaldamage = 150;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }
    //public void MinusHealth()
    //{
    //    sliderHP.value = sliderHP.value - Random.Range(minimaldamage, maximaldamage);
    //    Debug.Log(health);

    //}

}
