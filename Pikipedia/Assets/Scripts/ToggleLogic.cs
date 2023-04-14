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
            PlayMenu.rounds_max = _Toggle.name[_Toggle.name.Length-1];
        }
        else if (_Toggle.isOn && _Toggle.group.name == "LevelsText");
        {
            PlayMenu.levels = _Toggle.name[_Toggle.name.Length-1];
        }
        
    }
    
}
