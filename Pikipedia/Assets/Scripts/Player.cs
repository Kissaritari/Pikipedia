using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
    public int health = 100;
    private healthBar PlayerHealthBar;
    public static int ID = 0;
    public int playerID;
 


    void Awake()
    {
        ID ++;
        playerID = ID;     // sets the player Id
        
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
