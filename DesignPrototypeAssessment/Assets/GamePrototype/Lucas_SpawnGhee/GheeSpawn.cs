using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GheeSpawn : MonoBehaviour
{

    //By Fynn Burgess.

    //Gameobject.

    //Refrence to the enemy object.
    //I changed "_enemy" to "_ghee" 
    [SerializeField] GameObject _ghee;

    [SerializeField] GameObject _player;

    //Array.

    //Creats there int varibles.
    int xvalue;
    int zvalue;
    int yvalue;

    //Float.

    //Creating _enemiesInScene int.
    [SerializeField] int _GheeInScene;

    //Creating _numberofGhee int.
    [SerializeField] int _numberofGheeHeld;

    //Bools.

    //Creats _timeAtthree bool.
   public bool pickedUp;

//I made CanDeposite.
    [SerializeField] bool CanDeposite;

    //Creating _numberofSpawns int.

    [SerializeField] int _numberofSpawns;

    //I created deposited to test.
    [SerializeField] bool deposited;

    private void Start()
    {
        pickedUp = true;
        Spawn();
    }


    //I added a function called OnPressed that calls, on spacebar down to test.
    /*public void OnPressed()
    {

        //Started spawn function.
        Spawn();
    }*/

   //For spawning once one is pickedup.

    //WaitTime IEnumerator used for a delay in spawning.
    //I changed "WaitTime" to "Spawn" & changed it to a void.

    public void Spawn()
    {
        //If PickedUp is true.
        if (pickedUp == true)
        {
            //I changed the values.
            zvalue = Random.Range(221, 37);
            xvalue = Random.Range(-50, 18);
            yvalue = Random.Range(-7, -7);
            Instantiate(_ghee, new Vector3(xvalue, yvalue, zvalue), _player.transform.rotation);

            pickedUp = false;
            
        }

       
        
    }


    //Private void spawn. Spawns enemies. 
    //I made it spoawn ghee.
    /* void Spawn()
     {
         //I added this while loop.
         //While _enemiesInScene != _numberofGheeHeld the player can't deposite.

         while (_GheeInScene != _numberofGheeHeld)
         {
             CanDeposite = false;
         }

         //Checks to see if eneimesInScene doesn't equal AmountToSpawn. 

         if (deposited == true && _GheeInScene !=_numberofSpawns)
         {
             //While _numberofSpawns != _enemiesInScene spawn enemies randomly.
             while (_numberofSpawns != _GheeInScene)
             {
                zvalue = Random.Range(221, 37);
                xvalue = Random.Range(-50, 18);
                yvalue = Random.Range(1, 1);
             Instantiate(_ghee, new Vector3(xvalue, yvalue, zvalue), _player.transform.rotation);

             //_numberofspawns + 1.
             _numberofSpawns++;
             }
         }
     } */

  

}
