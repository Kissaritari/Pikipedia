using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{

    public int health = 100;    // Player's health
    private healthBar PlayerHealthBar; //  Player's healthbar
    public int playerID = 0;

    void Awake()
    {
        //playerID = GetComponents<Player>().Length;  // sets the player Id to the total number of player objects in play
     
    }

    void Start() 
    {
        PlayerHealthBar = transform.parent.GetChild(1).GetChild(0).GetComponent<healthBar>();
        
    } 
    
    public void TakeDamage (int damage)
    {
        health -= damage;
        PlayerHealthBar.SetHealth( health );
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
