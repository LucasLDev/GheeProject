using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    /*void Update()
    {
        RaycastHit hit;

        float distanceOfRay = 100;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distanceOfRay) && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Shot " + hit.transform.gameObject);
            Destroy(hit.transform.gameObject);
        }

        Debug.DrawLine(Camera.main.transform.position, Camera.main.transform.forward * distanceOfRay);


     
    }*/




    public GameObject raycastMarker = null;



    //public int ammoCount = 100;
    //public int clipSize = 15;
    //public int clipCount = 5;



    //public Text ammoText;
    //public Text clipText;



    /*private void UpdateText()
    {
    ammoText.text = ammoCount.ToString();
    clipText.text = clipCount.ToString();
    }*/



    /*private void Reload()
    {
    ammoCount += clipCount;



    if (ammoCount > clipSize)
    {
    clipCount = clipSize;
    ammoCount -= clipSize;
    }
    else
    {
    clipCount = ammoCount;
    ammoCount = 0;
    }
    UpdateText();
    }*/



    /*private void Start()
    {
    UpdateText();
    }*/



    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;



        float distanceOfRay = 100;



        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, distanceOfRay))
        {
            /*if (Input.GetKeyDown(KeyCode.R))
            {
            Reload();
            }*/



            if (Input.GetMouseButton(0))
            {
                /* if (clipCount <= 0)
                {
                return;
                }*/



                //clipCount--;
                //UpdateText();



                raycastMarker.transform.position = hit.point;
                hit.transform.position = hit.transform.position + Vector3.up;
            }
        }



        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * distanceOfRay);

    }
}


