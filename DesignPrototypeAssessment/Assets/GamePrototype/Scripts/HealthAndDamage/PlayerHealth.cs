using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 150f;
    public Slider healthSlider;

    private void Start()
    {
        health = maxHealth;
        maxHealth = healthSlider.maxValue;

        
    }

    private void Update()
    {
        healthSlider.value = health;
    }

    public void TakeDamage(float Amount)
    {
        health -= Amount;
        if(health <= 0)
        {
            Debug.Log("You Ded");
            Destroy(gameObject);
        }
    }


}
