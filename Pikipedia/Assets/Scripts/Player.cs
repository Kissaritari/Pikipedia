using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    public int health = 100; // Player's health
    private healthBar PlayerHealthBar; //  Player's healthbar
    public static int ID = 0;
    public int playerID = 0;
    private GameObject winner;
    public Canvas PointsHUD;
    public Text pointsText;
   

    void Awake()
    {
        ID ++;
        playerID = ID;     // sets the player Id
        
    }

    void Start() 
    {
        PointsHUD.enabled = true;
        PlayerHealthBar = transform.parent.GetChild(1).GetChild(0).GetComponent<healthBar>(); // Gets the healthBar component from the player.
        
    } 
    
    public void TakeDamage (int damage)
    {
        health -= damage;
        PlayerHealthBar.SetHealth( health );
        if (health <= 0)
        {
            Die();
            winner = GameObject.FindWithTag("Player");
            Debug.Log(winner);
            AddPoints();

            PlayMenu.ChangeLevel();
            
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    
    void AddPoints()
    {

        MainMenu.PointsDict.Add(winner.name, 1);
        


        foreach(var rivi in MainMenu.PointsDict)
        {
            Debug.Log($"Id: {rivi.Key}, Pisteet: {rivi.Value}");
            pointsText.text = rivi.Value.ToString();
        }
       
    }
    
}
