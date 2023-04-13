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
    public Text levelsText1;
    public Text levelsText2;
    public Canvas RoundEndScreen;
    public static int[] score ={0,0,0,0};

    void Awake()
    {
        ID ++;
        playerID = ID;    // sets the player  
        pointsText1.text = score[0].ToString();
        pointsText2.text = score[1].ToString();
        levelsText1.text = score[2].ToString();
        levelsText2.text = score[3].ToString();
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
            
            RoundEndScreen.enabled = true;                      
            AddPoints();
            pointsText1.text = score[0].ToString();
            pointsText2.text = score[1].ToString();
            levelsText1.text = score[2].ToString();
            levelsText2.text = score[3].ToString();
            RectTransform pointsTextnew = pointsText1.GetComponent<RectTransform>();
            pointsTextnew.anchoredPosition = new Vector3(-150.1767f, 54.35f, 0f);
            RectTransform pointsTextnew2 = pointsText2.GetComponent<RectTransform>();
            pointsTextnew2.anchoredPosition = new Vector3(149.82f, 54.35f, 0f);
            Die();

        }
    }

    void Die()
    {
        Destroy(transform.parent.gameObject);
    }
    
    void AddPoints()
    {
        if (playerID == 1)
        {
            score[0] += 1;
        }   
        else if (playerID == 2)
        {
            score[1] += 1;
        }
        if (score[0]+score[1] == PlayMenu.rounds_max)
        {
            if (score[0] > score[1])
            {
                score[2] += 1;    
            }
            else
            {
                score[3] += 1;
            }

      
        }
    }
    
}
