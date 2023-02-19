using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
<<<<<<< Updated upstream
    public float speed = 20f;
    public int damage = 20;
=======

    public float speed = 5f;
>>>>>>> Stashed changes
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

<<<<<<< Updated upstream
    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
        Player player = hitInfo.GetComponent<Player>();
        
        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

=======
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
>>>>>>> Stashed changes
}
