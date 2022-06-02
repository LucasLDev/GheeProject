using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
     private void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth PlayerComponent))
         {
             PlayerComponent.TakeDamage(25);
         }
     }
}
