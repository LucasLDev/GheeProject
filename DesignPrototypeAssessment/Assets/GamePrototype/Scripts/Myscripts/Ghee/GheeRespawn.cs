using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GheeRespawn : MonoBehaviour
{
    GheeSpawn _ghee;

    private void Start()
    {
        //find gheeSpawn object
        _ghee = FindObjectOfType<GheeSpawn>();
    }
    private void OnCollisionStay(Collision other)
    {

        if (gameObject.tag == "Ghee")
        {
            Debug.Log("Respawn");
            //spawn ghee
            _ghee.Spawn();
            //destroy ghee
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerStay(Collider other)
    {

        if (gameObject.tag == "Ghee")
        {
            Debug.Log("Respawn");
            //spawn ghee
            _ghee.Spawn();
            //destroy ghee
            Destroy(this.gameObject);
        }

    }
}
