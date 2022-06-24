using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    [SerializeField] Slider Bar;
    public int amountOfGhee;
    public int currentGheeOnPlayer;
    [SerializeField] PickupScript pickUpScript;
    [SerializeField] GheeSpawn gheeSpawn;
    [SerializeField] Deposit deposit;
    [SerializeField] TextMeshProUGUI gheetext;
    


    void Start()
    {
        Bar.value = 0;
        gheetext.text = "COLLECTED: " + amountOfGhee.ToString();
        pickUpScript = FindObjectOfType<PickupScript>();
        gheeSpawn = FindObjectOfType<GheeSpawn>();
        
    }


    void Update()
    {
        //if the ghee is stored set players ghee to 0 and update ghee bar text
        if (deposit.stored == true)
        {
            amountOfGhee = 0;
            gheetext.text = "COLLECTED: " + amountOfGhee.ToString();
            deposit.stored = false;
        }
        //amountOfGhee += currentGheeOnPlayer;
        
        if (gheeSpawn.claim == true)
        {
            SetBar();
        }
    }
    public void SetBar()
    {
        if (gheeSpawn.claim == true)
        {
            //how much the ghee gives the player
            currentGheeOnPlayer = Random.Range(5, 15);
            
            //add collected ghee to holdig ghee
            amountOfGhee += currentGheeOnPlayer;

            //New ghee amount becomes new maximum
            Bar.maxValue = amountOfGhee;
            Bar.value = Bar.maxValue;

            //display amount of ghee
            gheetext.text = "COLLECTED: " + amountOfGhee.ToString();

            //Start depletion of ghee
            StartCoroutine(depletion());

            gheeSpawn.claim = false;
        }
    }



    IEnumerator depletion()
    {
        //wait for x seconds before starting depletion
        yield return new WaitForSeconds(5);
        Debug.Log("waited");

        //if amount of ghee is greater than zero, take ghee, update ghee bar, update text
        if(amountOfGhee > 0)
        {
            amountOfGhee--;
            Bar.value = amountOfGhee;
            gheetext.text = "COLLECTED: " + amountOfGhee.ToString();
            StartCoroutine(depletion());
        }
        
        
    }
}
