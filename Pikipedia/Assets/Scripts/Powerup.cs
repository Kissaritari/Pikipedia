using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public GameObject pickupEffect;
    public float duration = 5f;
	private int damage = -20;

   void OnTriggerEnter2D (Collider2D collision) 
	{
        
        if (collision.tag == "Player")
        {
            StartCoroutine( Pickup(collision) );            
        }
	}

    IEnumerator Pickup(Collider2D player)
	{
		Instantiate(pickupEffect, transform.position, transform.rotation);

		Player play = player.GetComponent<Player>();
		play.TakeDamage(damage);

        GetComponent<SpriteRenderer>().enabled = false;
		GetComponent<Rigidbody2D>().simulated = false;
        GetComponent<Collider2D>().enabled = false;

    	yield return new WaitForSeconds(duration);

		Destroy(gameObject);
	}
}