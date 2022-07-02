using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCombt : MonoBehaviour
{
    public Animator anim;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attakRange = 0.5f;
    public int attackDamage = 30;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }

    void Attack ()
    {
        //attack animation
        anim.SetTrigger("Attack");

        //detect enemies
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attakRange, enemyLayers);

        //damage them
        foreach(Collider enemy in hitEnemies)
        {
            enemy.GetComponent<EnemyAI>().EnemyDamage(attackDamage);
        }

        
    }
    void OnDrawGizmosSelected()
        {
            if (attackPoint == null)
            {
                return;
            }
            Gizmos.DrawWireSphere(attackPoint.position, attakRange);
                
        }
}
