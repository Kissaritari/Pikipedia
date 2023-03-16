using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{

    public int health = 100; // Player's health
    public healthBar healthBar; // Player's healthbar
    public int playerID;



    void Start() 
    {
        Debug.Log("Max rounds: " + PlayMenu.rounds_max);
        Debug.Log("Rounds remaining: " + PlayMenu.rounds);
        Debug.Log("Levels remaining: " +PlayMenu.levels);
        Debug.Log("Player " + playerID + "id: " + playerID);
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
        PlayMenu.ChangeLevel();

    }
    // Start is called before the first frame update

}
