using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemiesSpawner : MonoBehaviour
{

    //Refrence to the enemy object.
    [SerializeField] GameObject EnemySpawner;

    [SerializeField] GameObject _player;

    //Creats there int varibles.
    int xvalue;
    int zvalue;
    int yvalue;

   //Bools.
   public bool EnemyKilled;

    //On start spawn enemies
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
            //Picks values betweem a given range randomly
            zvalue = Random.Range(226, 26);
            xvalue = Random.Range(-60, 68);
            yvalue = Random.Range(2, 2);

            //spawn an enemy with the generated values
            Instantiate(EnemySpawner, new Vector3(xvalue, yvalue, zvalue), _player.transform.rotation);

            //reset
            EnemyKilled = false;
            
        }
    }
}
