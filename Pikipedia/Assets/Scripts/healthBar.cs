using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public Player player;
    
    public Transform TargetToFollow;
    private Vector3 Offset;
     private void Start()
    {
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = player.health;
        healthBar.value = player.health;
        
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
        if ( healthBar.value <= 0 ) {
            Destroy(gameObject);
        }
    }
}
