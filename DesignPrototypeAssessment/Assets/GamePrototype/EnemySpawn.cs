using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemiesSpawner : MonoBehaviour
{

    //By Fynn Burgess.

    //Gameobject.

    //Refrence to the enemy object.
    [SerializeField] GameObject EnemySpawner;

    [SerializeField] GameObject _player;

    //Creats there int varibles.
    int xvalue;
    int zvalue;
    int yvalue;

    //Bools.
   public bool EnemyKilled;

    private void Start()
    {
        EnemyKilled = true;
        EnemySpawn();
    }

    public void EnemySpawn()
    {
        //If enemykilled is true.
        if (EnemyKilled == true)
        {
            //I changed the values.
            zvalue = Random.Range(221, 37);
            xvalue = Random.Range(-50, 18);
            yvalue = Random.Range(3, 3);
            Instantiate(Enemy, new Vector3(xvalue, yvalue, zvalue), _player.transform.rotation);

            EnemyKilled = false;
            
        }
    }
}
