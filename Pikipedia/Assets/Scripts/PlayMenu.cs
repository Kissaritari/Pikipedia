using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayMenu : MonoBehaviour
{
    public int rounds;
    public int levels;
    public void setRounds()
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name;
        if ( ClickedButtonName == "1Button")
        {
            rounds = 1;
        }
        else if (ClickedButtonName == "3Button")
        {
            rounds = 3;
        }
        else if (ClickedButtonName == "5Button")
        {
            rounds = 5;
        }
        else if (ClickedButtonName == "7Button")
        {
            rounds = 7;
        }
        Debug.Log(rounds);

        
    
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
        Debug.Log(levels);
    }



}
