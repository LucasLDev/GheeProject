using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inside : MonoBehaviour
{
    public GameManager _pseudo;

    private void OnTriggerEnter(Collider other)
    {
        if (_pseudo.holdingLog)
        {
            _pseudo.holdingLog = false;
            _pseudo.houseWoodPile++;
        }
    }
}
