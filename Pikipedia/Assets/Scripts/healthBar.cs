using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    private Slider SliderHealthBar;
    private Player player; // the player object whose health is tracked
    
    private Transform TargetToFollow; // The selected target (player) the healthbar follows
    private Vector3 Offset;
     private void Start()
    {
        player = transform.parent.parent.GetChild(0).GetComponent<Player>();
        TargetToFollow = player.transform;
        Debug.Log(transform.parent.parent.GetChild(0));
        SliderHealthBar = GetComponent<Slider>();   // selects the slider component for the healthbar to use
        SliderHealthBar.maxValue = player.health;
        SliderHealthBar.value = player.health;  // sets the max and current values to the healthbar
       
        Offset = transform.position - TargetToFollow.position;	// sets the starting position of the healthbar
        
    }

    void LateUpdate ()
	{
		transform.position = TargetToFollow.position + Offset;  // moves the healthbar according to the movement of the follow target 
	}
    public void SetHealth(int HitPoints)
    {
        SliderHealthBar.value = HitPoints;
        if ( SliderHealthBar.value <= 0 ) {
            Destroy(gameObject);                // if the value of the healthbar drops down to zero or less, destroys the healthbar object
        }
    }
}
