using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public static int ID = 0; // The number to be used as playerID
    public int playerID = 0; // Player's ID
    public int health = 100; // Player's health
    private healthBar PlayerHealthBar; //  Player's healthbar

    public static int[] score ={0,0,0,0}; // Players' score

    public Text pointsText1; // Initialize the points and levels
    public Text pointsText2;
    public Text levelsText1;
    public Text levelsText2;

    private Animator animator;
    private string resource;


    public Canvas RoundEndScreen; // Initialize canvases
    public Canvas pointsBackground;
    public Canvas GameEndScreen;
    public Canvas PointsHUD;
    
    void Awake() 
    {
        ID ++;

        playerID = ID; // sets the player ID 
        pointsText1.text = score[0].ToString(); // Display points and levels
        pointsText2.text = score[1].ToString();
        levelsText1.text = score[2].ToString();
        levelsText2.text = score[3].ToString();

        animator = transform.GetComponent<Animator>(); // sets the animator component

        if (playerID == 1)
        {
            resource = "B_Controller";
        }
        else if (playerID == 2)
        {
            resource = "Y_Controller";
        }

        animator.runtimeAnimatorController = Resources.Load(resource) as RuntimeAnimatorController; // changes the animator component

    } 
    
    void Start()
    {
        PauseMenu.IsPaused = false; // Display certain canvases
        RoundEndScreen.enabled = false;
        pointsBackground.enabled = true;
        GameEndScreen.enabled = false;
        PointsHUD.enabled = true;
        
        PlayerHealthBar = transform.parent.GetChild(1).GetChild(0).GetComponent<healthBar>(); // Gets the healthBar component from the player.
    } 
    
    public void TakeDamage (int damage) 
    {
        health -= damage; 
        PlayerHealthBar.SetHealth( health );
        if (health <= 0)
        {
            if (PlayMenu.levels >= 1 && PlayMenu.rounds > 0) // If the game still continues
            {
                RoundEndScreen.enabled = true; // Pause the game
                PauseMenu.IsPaused = true; // Display the round end screen
                pointsBackground.enabled = false;      
            }
            if (PlayMenu.levels == 0 && PlayMenu.rounds == 1) // If the game ends
            {
                PauseMenu.IsPaused = true; // Display the game end screen
                pointsBackground.enabled = false;
                GameEndScreen.enabled = true;
            }
            if (Player.score[2] == Player.score[1] && PlayMenu.rounds == 1 && PlayMenu.levels == 1) // If the game ends in a draw
            {
                PauseMenu.IsPaused = true; // Pause the game
                GameEndScreen.enabled = true; // Display the game end screen
                pointsBackground.enabled = false;
            }
            AddPoints(); // Add points to the winner

            pointsText1.text = score[0].ToString(); // Update the points in the hud
            pointsText2.text = score[1].ToString();
            levelsText1.text = score[2].ToString();
            levelsText2.text = score[3].ToString();

            RectTransform pointsTextnew = pointsText1.GetComponent<RectTransform>(); // move the points from the hud to the round end screen
            pointsTextnew.anchoredPosition = new Vector3(-150.1767f, 54.35f, 0f);
            RectTransform pointsTextnew2 = pointsText2.GetComponent<RectTransform>();
            pointsTextnew2.anchoredPosition = new Vector3(149.82f, 54.35f, 0f);

            StartCoroutine(Die()); // Kill the player
        }
        else if (health >= 100) // If players health exceeds 100 it gets set to 100
        {
            health = 100;
        }
    }

    IEnumerator Die()
    {
        animator.Play("Die",0);
        yield return new WaitForSeconds(2.5f); // Wait for 2.5 seconds
        Destroy(transform.parent.gameObject);
        PlayMenu.ChangeLevel(); // Move on to the next level
    }
    
    void AddPoints()
    {
        if (playerID == 1) // Set the points to the winner player
            score[0] += 1;
           
        else if (playerID == 2)
            score[1] += 1;

        if (score[0]+score[1] == PlayMenu.rounds_max) // If all the rounds have been played
        {
            if (score[0] > score[1]) // Give a round point to the winner
                score[2] += 1;    

            else
                score[3] += 1;
        }
    }   
}
