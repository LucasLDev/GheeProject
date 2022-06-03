using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Deposit : MonoBehaviour
{
    public Inventory inventory;
    public int storedGhee;
    public bool stored;
    public Slider slider;
    [SerializeField] int number;
    public int goal = 50;

    public string messageToShow = "Default Message";
    public float messageDuration = 1;

    private void Update()
    {
        if (storedGhee >= goal)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter(Collider other)
    {



        if (other.tag == "Player")
        {
            GameObject.FindObjectOfType<UIController>().
            ShowMessage(messageToShow, messageDuration);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E) && inventory.amountOfGhee > 1)
            {
                number = storedGhee;
                storedGhee = inventory.amountOfGhee;
                storedGhee = storedGhee + number;
                slider.maxValue = 0;
                slider.value = slider.maxValue;
                stored = true;
               
            }
        }
    }
    
}
