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
    public Text pointsText1;
    public Text pointsText2;
    public Canvas RoundEndScreen;
    public int score;

    
   

    void Awake()
    {
        ID ++;
        playerID = ID;     // sets the player Id
        
    }

    void Start() 
    {
        RoundEndScreen.enabled = false;
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
            RoundEndScreen.enabled = true;
            winner = GameObject.FindWithTag("Player");
            Debug.Log(winner.name);
            AddPoints();
            RectTransform pointsTextnew = pointsText1.GetComponent<RectTransform>();
            pointsTextnew.anchoredPosition = new Vector3(-150.1767f, 54.35f, 0f);
            RectTransform pointsTextnew2 = pointsText2.GetComponent<RectTransform>();
            pointsTextnew2.anchoredPosition = new Vector3(149.82f, 54.35f, 0f);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    
    void AddPoints()
    {
        score += 1;
        MainMenu.PointsDict.Add(winner.name, score);
        foreach(var rivi in MainMenu.PointsDict)
        {
            if (rivi.Key == "Player1")
            {
                pointsText1.text = rivi.Value.ToString();
            }
            if (rivi.Key == "Player2")
            {
                pointsText2.text = rivi.Value.ToString();
            }
            // Debug.Log($"Id: {rivi.Key}, Pisteet: {rivi.Value}");
            
        }
       
    }
    
}
