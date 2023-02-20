using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int health = 100;
    public HealthBar healthBar;
    static int id = 0;
    public int playerID;

    void start() 
    {
        id ++;
        playerID = id;
    } 
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
        SceneManager.LoadScene("Main Menu"); 

    }
    // Start is called before the first frame update


    // Update is called once per fr
}
