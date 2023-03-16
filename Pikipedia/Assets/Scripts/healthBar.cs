using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    private Slider SliderHealthBar;
    public Player player;
    
    public Transform TargetToFollow;
    private Vector3 Offset;
     private void Start()
    {
        SliderHealthBar = GetComponent<Slider>();
        SliderHealthBar.maxValue = player.health;
        SliderHealthBar.value = player.health;
        
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
        SliderHealthBar.value = hp;
        if ( SliderHealthBar.value <= 0 ) {
            Destroy(gameObject);
        }
    }
}
