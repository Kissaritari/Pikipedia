using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public GameObject pickupEffect;

   void OnTriggerEnter2D (Collider2D collision) 
   {
        
        if (collision.tag == "Testi")
        {
            Pickup();            
        }
   }

   void Pickup()
   {
     Destroy(gameObject);
   }
}
