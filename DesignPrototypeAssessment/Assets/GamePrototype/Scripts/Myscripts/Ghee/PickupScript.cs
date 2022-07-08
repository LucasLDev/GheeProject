using UnityEngine;

public class PickupScript : MonoBehaviour
{

    [SerializeField] GheeSpawn _gheeSpawn;
    public Inventory inventory;
    public float radius;


    private void Start()
    {
        _gheeSpawn = FindObjectOfType<GheeSpawn>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //player enters the ghee's trigger
        if (other.gameObject.tag == "Player")
        {
            
            //player picks up ghee
            _gheeSpawn.pickedUp = true;
            //new ghee is spawned
            _gheeSpawn.Spawn();
            _gheeSpawn.claim = true;

            //picked up ghee object is destroyed
            Destroy(gameObject);

            _gheeSpawn.pickedUp = true;
            _gheeSpawn.Spawn();

        }
    }
        
}
