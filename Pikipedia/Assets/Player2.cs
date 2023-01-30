using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

    public int health = 100;


    public void TakeDamage2 (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die2();
        }
    }

    void Die2()
    {
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}