using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outside : MonoBehaviour
{
    public GameManager _pseudo;
    private void OnTriggerEnter(Collider other)
    {
        
        _pseudo.holdingLog = true;
        _pseudo.shedWoodPile--;
        
    }
}
