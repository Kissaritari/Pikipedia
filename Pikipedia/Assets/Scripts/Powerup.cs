using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject pickupEffect; // Electric poof when powerup is picked up
    public float duration = 5f; // Duration of some powerups
	private int damage = -20; // This negative damage value is used to heal player when powerup is picked up

   void OnTriggerEnter2D (Collider2D collision)
	{
        
        if (collision.tag == "Player") // when player touches the powerup
        {  
            Effect(collision); // Method for powerups gameplay effecting stuff
			StartCoroutine( Pickup(collision) ); // Method for removing the powerup      
        }
	}

    IEnumerator Pickup(Collider2D player)
	{
		Instantiate(pickupEffect, transform.position, transform.rotation); // Electric poof when powerup is picked up

        GetComponent<SpriteRenderer>().enabled = false; // Disable collisions and visuals from collided powerup
		GetComponent<Rigidbody2D>().simulated = false;
        GetComponent<Collider2D>().enabled = false;
		
    	yield return new WaitForSeconds(duration); // wait for the powerup effect to end before destroying
		Destroy(gameObject);
	}

	void Effect(Collider2D player)
	{
		//int randomNumber = Random.Range(0,1);
		Player play = player.GetComponent<Player>(); // Placeholder powerup effect that heals the player by 20 health
		play.TakeDamage(damage);
	}
}