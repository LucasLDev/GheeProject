using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woodsman : MonoBehaviour
{

    [SerializeField] GameObject _wood;

    [SerializeField] GameObject _agent;
    
    private const int V = 0;
    int insideWood = 5;
    int collectedWood = 0;

    void Start()
    {

    }

}
