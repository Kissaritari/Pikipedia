using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f; // Bullet speed
    public int damage = 20; // Bullet's damage
    public Rigidbody2D rb; // Formatting a rigidbody2d as rb

    
    void Start() // Called at the start
    {
        rb.velocity = transform.right * speed; // Bullet moves right with the given speed
    }

    void OnTriggerEnter2D(Collider2D hitInfo) // Called when the bullet hits any collider
    {
        Player player = hitInfo.GetComponent<Player>(); // Bullet object recognized the player object on impact
        
        if (player != null && !PauseMenu.IsPaused) // If the bullet hits a player
        {
            player.TakeDamage(damage); // Call the TakeDamage function
        }
        Destroy(gameObject); // Destroy the bullet on impact
    }

}
