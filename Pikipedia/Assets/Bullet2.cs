using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        Player2 player = hitInfo.GetComponent<Player2>();
        if (player != null)
        {
            player.TakeDamage2(damage);
        }
        Destroy(gameObject);
    }

}