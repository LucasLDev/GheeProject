using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{

    private bool quitting = false;

    [SerializeField] EnemiesSpawner _enemySpawn;
   

    private void Start()
    {
        _enemySpawn = FindObjectOfType<EnemiesSpawner>();
    }

    private void OnApplicationQuit()
    {
        quitting = true;
    }


    //When enemy is destroyed spawn a new enemy
    //Added a timer that counts down after killing an enemy before spawning another
    private void OnDestroy()
    {
        if (!quitting)
        {
            _enemySpawn.EnemyKilled = true;
            _enemySpawn.EnemySpawn();
            Destroy(gameObject);
        }
    }


}
