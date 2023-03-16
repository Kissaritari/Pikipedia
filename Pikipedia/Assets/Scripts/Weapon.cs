using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private Transform firePoint;
    public GameObject bulletPrefab;
    private Player player;

    // Update is called once per frame
    private void Start() 
    {
        player = GetComponent<Player>();
        firePoint = transform.GetChild(1);
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire" + player.playerID.ToString()))
        {
            Shoot();
        }
        
       
        
    }

    void Shoot()
    {
        // shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
