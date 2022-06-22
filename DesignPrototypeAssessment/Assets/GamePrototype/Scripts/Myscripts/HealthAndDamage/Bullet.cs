using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.TryGetComponent<EnemyAI>(out EnemyAI EnemyComponent))
        {
            EnemyComponent.EnemyDamage(25);
        }

        Destroy(gameObject);
    }
}
