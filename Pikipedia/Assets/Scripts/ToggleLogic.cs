using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToggleLogic : MonoBehaviour
{
    private Toggle _Toggle;
    // Start is called before the first frame update
    void Awake()
    {
        _Toggle = GetComponent<Toggle>();

    //Add listener for when the state of the Toggle changes, and output the state
        _Toggle.onValueChanged.AddListener(delegate {
                ToggleValueChanged(_Toggle);
            });
    }

    //Output the new state of the Toggle into Text when the user uses the Toggle
    void ToggleValueChanged(Toggle change)
    {
        if (_Toggle.isOn && _Toggle.group.name == "RoundsText")
        { 
            char charRound = _Toggle.name[_Toggle.name.Length-1];
            int intRound = charRound - '0'; // convert char to int
            PlayMenu.rounds_max = intRound; // rounds_max set to the last letter of the selected toggle's name
            PlayMenu.rounds = PlayMenu.rounds_max;
           
          
        }
        if (_Toggle.isOn && _Toggle.group.name == "LevelsText")
        {
            char charLevel = _Toggle.name[_Toggle.name.Length-1];
            int intLevel = charLevel - '0'; // convert char to int
            PlayMenu.levels = intLevel; // levels set to the last letter of the selected toggle's name
        }
        
    }
    
}
