using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpawn : MonoBehaviour
{
    //public string to customise message
    public string messageToShow = "Default Message";

    //float to define duration
    public float messageDuration = 3;



    private void OnTriggerEnter(Collider other)
    {
        //if player walks through trigger
        //show desired message for a duration
        if (other.tag == "Player")
        {
            GameObject.FindObjectOfType<UIController>().
            ShowMessage(messageToShow, messageDuration);
        }
    }
}
