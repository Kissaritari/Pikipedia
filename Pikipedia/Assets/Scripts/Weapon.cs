using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    private Transform firePoint;  // Make a point from which the weapon fires the bullet
    public GameObject bulletPrefab; // Make a bullet prefab
    private Player player;
    private Animator animator;
    private float fireRate = 0.3f;
    private float nextFire = 0f;

    private void Start() 
    {
        player = GetComponent<Player>();
        firePoint = transform.GetChild(1);
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire" + player.playerID.ToString()) && Time.time > nextFire) // When the fire button is pressed
        {
            Shoot();
            nextFire = Time.time + fireRate;
        }     
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Spawn the prefab in in the firePoint and the correct way around
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle") | animator.GetCurrentAnimatorStateInfo(0).IsName("Fire") && animator.GetFloat("xinput") < 0.3f)
        animator.Play("Fire",0);
    }
}
