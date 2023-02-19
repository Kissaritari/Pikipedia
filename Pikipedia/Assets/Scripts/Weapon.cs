using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
<<<<<<< Updated upstream
    public Transform firePoint;
    public GameObject bulletPrefab;
=======

    public Transform firePoint;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
>>>>>>> Stashed changes

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
<<<<<<< Updated upstream
    }

    void Shoot() 
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
=======
        
        
    }

    void Shoot ()
    {
        // shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

>>>>>>> Stashed changes
    }
}
