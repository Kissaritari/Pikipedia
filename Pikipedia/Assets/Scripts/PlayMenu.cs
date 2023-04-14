using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayMenu : MonoBehaviour
{
    public static int rounds = 3; // Remaining rounds
    public static int rounds_max = 3; // Maximum rounds per level
    public static int levels = 5; // Amount of levels



    public void setRounds()
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name; // get the name of the clicked object
        if ( ClickedButtonName == "1Button")  // If it's 1button 
        {
            rounds_max = 1; // set the max rounds to 1
            rounds = 1;
        }
        else if (ClickedButtonName == "3Button") // etc.
        {
            rounds_max = 3;
            rounds = 3;
        }
        else if (ClickedButtonName == "5Button")
        {
            rounds_max = 5;
            rounds = 5;
        }
        else if (ClickedButtonName == "7Button")
        {
            rounds_max = 7;
            rounds = 7;
        }   
        Debug.Log(rounds);
        
    }

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
                SceneManager.LoadScene("Main Menu");
            }
        }
    }

    public void setLevels ()
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name; // get the name of the clicked object
        if (ClickedButtonName == "Level1")// If it's level1 
        {
            levels = 1; // set the levels to 1
        }
        else if (ClickedButtonName == "Level2") // etc.
        {
            levels = 2;
        }
        else if (ClickedButtonName == "Level3")
        {
            levels = 3;
        }
        else if (ClickedButtonName == "Level4")
        {
            levels = 4;
        }
        else if(ClickedButtonName == "Level5")
        {
            levels = 5;
        }
        Debug.Log(levels);
        
    }
}
