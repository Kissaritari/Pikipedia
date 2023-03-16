using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Slider sliderhealthBar;
    public Player player;
    
    public Transform TargetToFollow;
    private Vector3 Offset;
     private void Start()
    {
        sliderhealthBar = GetComponent<Slider>();
        sliderhealthBar.maxValue = player.health;
        sliderhealthBar.value = player.health;
        
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
        sliderhealthBar.value = hp;
        if ( sliderhealthBar.value <= 0 ) {
            Destroy(gameObject);
        }
    }
}
