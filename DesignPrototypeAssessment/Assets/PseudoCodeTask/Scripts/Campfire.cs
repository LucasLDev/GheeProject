using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : MonoBehaviour
{
    public GameManager _pseudo;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Woodsman")
        {
            _pseudo.fireLit = true;
            _pseudo.LightFire();
        }      
    }
}
