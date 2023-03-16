using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Player player;
    [SerializeField] private AudioSource GunFire;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire" + player.playerID.ToString()) && player.playable != false)
        {
            Shoot();
            GunFire.Play();
        }
        
       
        
    }

    void Shoot()
    {
        // shooting logic
        /*/ if (PauseMenu.IsPaused == false)
         {
             Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
         }
         /**/
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
