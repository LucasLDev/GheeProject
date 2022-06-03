using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpawn : MonoBehaviour
{
    public string messageToShow = "Default Message";
    public float messageDuration = 3;



    private void OnTriggerEnter(Collider other)
    {



        if (other.tag == "Player")
        {
            GameObject.FindObjectOfType<UIController>().
            ShowMessage(messageToShow, messageDuration);
        }
    }
}
