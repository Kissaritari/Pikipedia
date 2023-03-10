using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{

    public int health = 100;
    public healthBar healthBar;
    public int playerID;


    void Start() 
    {
        Debug.Log(PlayMenu.rounds);
        Debug.Log(PlayMenu.levels);
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
