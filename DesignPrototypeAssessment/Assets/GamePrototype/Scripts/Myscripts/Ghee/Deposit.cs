using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Deposit : MonoBehaviour
{
    public Inventory inventory;

    //Ghee bar slider
    public Slider slider;
    //Objective progress slider
    public Slider depositSlider;


    [SerializeField] int number;
    public int goal = 50;
    public int storedGhee;
    
    public bool stored;
    
    public string messageToShow = "Default Message";
    public float messageDuration = 1;


    private void Update()
    {
        //slider value always equals storedGhee value
        depositSlider.value = storedGhee;

        //if stored ghee is equal to or greater than the goal load desired scene
        if (storedGhee >= goal)
        {
            SceneManager.LoadScene("MainMenu");
        }

    }

    //Display how to deposit (Keybind)
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
            //if player presses E and held ghee is greater than 1 then
                // add held ghee to stored ghee and set ghee bar to 0
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
