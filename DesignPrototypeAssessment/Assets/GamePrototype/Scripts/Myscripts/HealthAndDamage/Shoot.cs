
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzle;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    void Fire()
    {
        //for when a make muzzle flash particle effect
        //muzzle.Play()

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            EnemyAI target = hit.transform.GetComponent<EnemyAI>();
            if (target != null)
            {
                target.EnemyDamage(damage);
            }
        }
    }



    /*
    //variables

    //game objects
    public GameObject GheeGun;
    public GameObject bulletPrefab;
    
    public Transform bulletSpawnpoint;

    public float bulletSpeed;


    private void Update()
    {
        //When the player presses left click on mouse
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //spawn bullet prefab and add force to it
            GameObject GO = Instantiate(bulletPrefab, bulletSpawnpoint.position, Quaternion.identity) as GameObject;
            GO.GetComponent<Rigidbody>().AddForce(GheeGun.transform.forward * bulletSpeed, ForceMode.Impulse);
        }
    }
    */

}


