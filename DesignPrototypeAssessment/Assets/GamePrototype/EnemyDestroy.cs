using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{

    [SerializeField] EnemySpawner enemySpawn;
    
    bool EnemyKilled;

    
    private void Start()
    {
        enemySpawn = FindObjectOfType<EnemySpawner>();
    }

     private void OnDestroy()
    {
        Destroy(gameObject);
        EnemyKilled = true;
        enemySpawn.EnemySpawn();
        
        
    }
}
