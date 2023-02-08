using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int health = 100;
    public HealthBar healthBar;

    public void TakeDamage (int damage)
    {
        health -= damage;
        healthBar.SetHealth( health );
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update


    // Update is called once per fr
}
