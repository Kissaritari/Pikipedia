using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{

    public int health = 100; // Player's health
    private healthBar PlayerHealthBar; //  Player's healthbar
    public static int ID = 0;
    public int playerID = 0;
    private Animator animator;
    private string resource;

    void Awake()
    {
        ID ++;
        playerID = ID;     // sets the player Id
        animator = transform.GetComponent<Animator>(); // sets the animator component

        if (playerID == 1)
        {
            resource = "B_Controller";
        }
        else if (playerID == 2)
        {
            resource = "Y_Controller";
        }

        animator.runtimeAnimatorController = Resources.Load(resource) as RuntimeAnimatorController;
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
        animator.Play("die",0);
        Destroy(gameObject);
        PlayMenu.ChangeLevel();

    }
    // Start is called before the first frame update

}
