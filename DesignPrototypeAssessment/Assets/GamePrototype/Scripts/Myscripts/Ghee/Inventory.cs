using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] Slider Bar;
    public int amountOfGhee;
    public int currentGheeOnPlayer;
    [SerializeField] PickupScript pickUpScript;
    [SerializeField] GheeSpawn gheeSpawn;
    [SerializeField] Deposit deposit;
    [SerializeField] Text gheetext;



    // Start is called before the first frame update
    void Start()
    {
        Bar.value = 0;
        gheetext.text = "COLLECTED: " + amountOfGhee.ToString();
        pickUpScript = FindObjectOfType<PickupScript>();
        gheeSpawn = FindObjectOfType<GheeSpawn>();
        
    }

    // Update is called once per frame
    void Update()
    {
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
            currentGheeOnPlayer = Random.Range(5, 15);
            amountOfGhee += currentGheeOnPlayer;
            //amountOfGhee = 5;
            Bar.maxValue = amountOfGhee;
            Bar.value = Bar.maxValue;
            gheetext.text = "COLLECTED: " + amountOfGhee.ToString();
            StartCoroutine(depletion());

            gheeSpawn.claim = false;
        }
    }



    IEnumerator depletion()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("waited");
        if(amountOfGhee > 0)
        {
            amountOfGhee--;
            Bar.value = amountOfGhee;
            gheetext.text = "collected: " + amountOfGhee.ToString();
            StartCoroutine(depletion());
        }
        
        
    }
}
