using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class Player : MonoBehaviour
{
    public bool playable = true;
    public int health = 100;
    public healthBar healthBar;
    public int playerID;
    public int player2points = 0;
    public int player1points = 0;
    [SerializeField] private AudioSource HitSound;
    [SerializeField] private AudioSource Death2;


    void Start() 
    {
        Debug.Log("Max rounds: " + PlayMenu.rounds_max);
        Debug.Log("Rounds remaining: " + PlayMenu.rounds);
        Debug.Log("Levels remaining: " +PlayMenu.levels);
        Debug.Log("Player " + playerID + "id: " + playerID);
    } 
    
    public void TakeDamage (int damage)
    {
        HitSound.Play();
        health -= damage;
        healthBar.SetHealth( health );
        if (health <= 0)
        {
            playable = false;
            StartCoroutine(Die());
            Death2.Play();
        }
    }

    IEnumerator Die()
    {
        
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(2);
        Destroy(healthBar);
        Destroy(gameObject);
        PlayMenu.ChangeLevel();

    }
    // Start is called before the first frame update

}
