using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    private Transform firePoint;  // Make a point from which the weapon fires the bullet
    public GameObject bulletPrefab; // Make a bullet prefab
    private Player player;

    // Update is called once per frame
    private void Start() 
    {
        player = GetComponent<Player>();
        firePoint = transform.GetChild(1);
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire" + player.playerID.ToString()) && !PauseMenu.IsPaused) // When the fire button is pressed
        {
            Shoot();
        }     
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Spawn the prefab in in the firePoint and the correct way around
    }
}
