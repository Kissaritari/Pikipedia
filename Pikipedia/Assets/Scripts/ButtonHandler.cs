using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonHandler : MonoBehaviour
{
    public void BackToMenu ()
    {
        SceneManager.LoadScene("Main Menu"); // Return to Menu
    }
}
