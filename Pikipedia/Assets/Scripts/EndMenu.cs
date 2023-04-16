using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public GameObject EndMenuUI;
   

    public void Quit() // Called when Quit is pressed
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
}
