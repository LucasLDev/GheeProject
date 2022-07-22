using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    private AudioSource audsrc;
    public AudioClip[] swapArray;
    public int equippedWeapon = 0;

    void Start()
    {
        SelectWeapon();
        audsrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        int previousSelectedWeapon = equippedWeapon;

        //switching to next/previous weapon via scroll wheel
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            PlayWeaponSwap();
            //StartCoroutine (WaitSeconds());
            if (equippedWeapon >= transform.childCount - 1)
            {
                
                equippedWeapon = 0;
            }
            else {
                equippedWeapon++;
            }
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            
            PlayWeaponSwap();
            //StartCoroutine (WaitSeconds());

            if (equippedWeapon <= 0)
            {
                
                equippedWeapon = transform.childCount - 1;
            }
            else {
                equippedWeapon--;
            }
        }

        //Swithing directly to weapon via keybind
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            equippedWeapon = 0;
        }

         if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            equippedWeapon = 1;
        }

        if (previousSelectedWeapon != equippedWeapon)
        {
            SelectWeapon();
        }
        
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == equippedWeapon)
            {
                weapon.gameObject.SetActive(true);
            } 
            else
            {
                weapon.gameObject.SetActive(false);
            }

            i++;
        }
    }

    void PlayWeaponSwap()
    {
        
        audsrc.PlayOneShot(swapArray[Random.Range(0, swapArray.Length -1)]);
    }

        IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(1);
    }
}
