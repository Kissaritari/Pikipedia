using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayMenu : MonoBehaviour
{
    public static int rounds; // Remaining rounds
    public static int rounds_max; // Maximum rounds per level, set to 3 at start
    public static int levels; // Amount of levels to be played, set to 5 at start

  
    public static void ChangeLevel()
    {

        rounds--; // Subtract from the remaining rounds
        Player.ID = 0;

        if (rounds == 0 && levels > 1) // If there are no remaining rounds and there are levels left
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1); // Load the scene of the next map
            Player.score[0] = 0; // reset the round win points
            Player.score[1] = 0; 
            levels--; // Subtract from the remaining levels
            rounds = rounds_max; // Set the current rounds to the max in the new map
        }
        else 
        {
            if (levels >=1 && rounds > 0) // If there are still levels
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Load the same map while rounds > 0;
            }
            else
            {
                SceneManager.LoadScene("Main Menu"); // Go back to menu
            }
        }
    }


}
