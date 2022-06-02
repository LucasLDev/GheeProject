using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 150f;

    private void Start()
    {
        health = maxHealth;
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
