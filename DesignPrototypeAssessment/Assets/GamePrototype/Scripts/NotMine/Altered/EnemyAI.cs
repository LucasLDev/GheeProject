using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Script by Dave/GameDevlopment on YouTube

public class EnemyAI : MonoBehaviour
{
    
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public float enemyHealth;

    public float moveSpeed;


    //Patrolling variables
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking variables
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //States of AI
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    
    private void Update()
    {
        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        //Calling the behaviour functions if gameplay conditions are met
        if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInAttackRange && !playerInSightRange) AttackPlayer();

        //I added if statement of when the enemy should die
        if (enemyHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void AttackPlayer()
    {
        throw new System.NotImplementedException();
    }

    //Function to make enemy walk around an area when not engaged
    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }
    

    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
            
    }

    //Enemy object moves towards player
    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    //Enemy attack Function, when collides with player it reduces the player's health
    private void AttackPlayer(Collision collision)
    {
        //Make sure enemy doesn't move
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        //I added my enemy attack to the script via collision.
        if (!alreadyAttacked)
        {
            if (gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth PlayerComponent))
            {
                PlayerComponent.TakeDamage(25);
            }

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    
    private void ResetAttack()
    {
        alreadyAttacked = false;
    } 

    //I added a coloured visual to display to the behaviour ranges
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, walkPointRange);
    }

    //Death of the enemy
    public void EnemyDamage(float damageAmount)
    {
        enemyHealth -= damageAmount;
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    //I added this function to take 'Health' off when colliding with a bullet
    private void BulletCollision(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            enemyHealth -= 1;
        }
    }
}
