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
    private void OnColliderStay(Collision other)
    {
        // if the tag of the object inside this object is "Ghee" 
        if (other.gameObject.tag == "Ghee")
        {
            Debug.Log("Respawn");
            //spawn ghee
            _ghee.Spawn();
            //destroy ghee
            Destroy(other.gameObject);
        }

    }
}
