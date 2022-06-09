using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    //float for total time on timer
    [SerializeField] EnemiesSpawner _enemySpawn;

    private void Start()
    {
        _enemySpawn = FindObjectOfType<EnemiesSpawner>();
    }

    //When enemy is destroyed spawn a new enemy
    //Added a timer that counts down after killing an enemy before spawning another
     private void OnDestroy(GameObject Enemy)
    {
        _enemySpawn.EnemyKilled = true;
        _enemySpawn.EnemySpawn();
        Destroy(gameObject);   
    }

}
