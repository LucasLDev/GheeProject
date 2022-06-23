using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{

    public int shedWoodPile;
    public int houseWoodPile;
    
    public bool fireLit;
    public bool holdingLog;

    public Vector3 outsidePile;

    public Vector3 insidePile;

    public Vector3 campfire;
  
    public NavMeshAgent Woodsman;

    public GameObject fire;

    void Start()
    {
        fireLit = false;
    }

    void Update()
    {
        if(houseWoodPile == 5)
        {
            Woodsman.destination = campfire;
        }

        if(holdingLog)
        {
            Woodsman.destination = insidePile;
        }

        if (!fireLit && houseWoodPile < 5 && !holdingLog)
        {
            Woodsman.destination = outsidePile;
        }


    }

    public void LightFire()
    {
        Instantiate(fire, new Vector3(364, 1, 355), Quaternion.identity); 
    }


}
