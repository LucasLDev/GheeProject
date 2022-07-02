using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
   /* public int equippedWeapon = 0;

    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (equippedWeapon >= transform.childCount - 1)
            {
                equippedWeapon = 0;
            }
            else{
                equippedWeapon++;
            }

            if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (equippedWeapon <= 0)
            {
                equippedWeapon = transform.childCount - 1;
            }
            else{
                equippedWeapon++;
            }
            
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
    }*/
}
