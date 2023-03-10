using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    public static int rounds;
    public static int rounds_max;
    public static int levels;
    public void setRounds()
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        if ( ClickedButtonName == "1Button")
        {
            rounds_max = 1;
            rounds = 1;
        }
        else if (ClickedButtonName == "3Button")
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
    }

    public static void ChangeLevel()
    {
        rounds--;

        if (rounds == 0 && levels > 1) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            levels--;
            rounds = rounds_max;
        }
        else 
        {
            if (levels >1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                SceneManager.LoadScene(6);
            }
            
        }

    }

    public void setLevels ()
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        if (ClickedButtonName == "Level1")
        {
            levels = 1;
        }
        else if (ClickedButtonName == "Level2")
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
    }



}
