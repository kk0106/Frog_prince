using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    public bool eggToShoot;// Start is called before the first frame update
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;
    public static int GetApple;



    private void Start()
    {
        GetApple = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (eggToShoot == true)
        {
            GetApple +=1;
        }

        if(GetApple == 3)
        {
            GetApple = 0;
        }

        if (UserInput.instance.controls.playerControls.ShootGun.WasPressedThisFrame())
        {
            // Fire a projectile
            Shoot();
            
            
        }
    }

    void Shoot()
    {
        if (eggToShoot)
        {
            // Set the offset distance forward
            float offsetDistance = 0.5f;

            // Calculate the new position with the offset
            Vector3 spawnPosition = transform.position + transform.forward * offsetDistance;

            // Create a new instance of the projectile prefab at the new position
            GameObject newProjectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

            // Access the Rigidbody of the projectile and apply forward force
            Rigidbody rb = newProjectile.GetComponent<Rigidbody>();
            rb.velocity = transform.forward* projectileSpeed;
           rb.useGravity = false;

            eggToShoot = false;
        }
    }
}