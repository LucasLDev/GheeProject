using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{

    public GameObject GheeGun;
    public GameObject bulletPrefab;
    public Transform bulletSpawnpoint;
    public float bulletSpeed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject GO = Instantiate(bulletPrefab, bulletSpawnpoint.position, Quaternion.identity) as GameObject;
            GO.GetComponent<Rigidbody>().AddForce(GheeGun.transform.forward * bulletSpeed, ForceMode.Impulse);
        }
    }

}


