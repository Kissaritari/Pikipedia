using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public Health playerHealth;
    
    public Transform TargetToFollow;
    private Vector3 Offset;
     private void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = playerHealth.maxHealth;
        healthBar.value = playerHealth.maxHealth;
        
        Offset = transform.position - TargetToFollow.position;	
    }

    public void update()
    {
    }
    void LateUpdate ()
	{
		transform.position = TargetToFollow.position + Offset;	
	}
    public void SetHealth(int hp)
    {
        healthBar.value = hp;
    }
}
