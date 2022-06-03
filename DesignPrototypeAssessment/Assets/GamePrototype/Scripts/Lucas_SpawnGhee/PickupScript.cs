using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{

    [SerializeField] GheeSpawn _gheeSpawn;
    public Inventory inventory;
    

    private void Start()
    {
        _gheeSpawn = FindObjectOfType<GheeSpawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            _gheeSpawn.pickedUp = true;
            _gheeSpawn.Spawn();
            _gheeSpawn.claim = true;
            Destroy(gameObject);
            //inventory.amountOfGhee = 

           
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
   
       _gheeSpawn.pickedUp = true;
        _gheeSpawn.Spawn();
    }

}
