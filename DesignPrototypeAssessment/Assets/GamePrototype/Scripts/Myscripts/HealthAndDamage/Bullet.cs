using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //if bullet collides with an enemy.
        if (collision.gameObject.TryGetComponent<EnemyAI>(out EnemyAI EnemyComponent))
        {
            //take 25 damage of the enemy's health
            EnemyComponent.EnemyDamage(25);
        }

        Destroy(gameObject);
    }
}
