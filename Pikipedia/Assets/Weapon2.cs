using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    public Transform firePoint2;
    public GameObject bulletPrefab2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    void Shoot() 
    {
        Instantiate(bulletPrefab2, firePoint2.position, firePoint2.rotation);
    }
}
