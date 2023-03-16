using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

 
    public static bool IsPaused = false; // create a variable of the games pause state
    public GameObject PauseMenuUI; // Reference to the UI

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // When escape is pressed
        {
            if (IsPaused) // If the game is already paused, resume
            {
                Resume();
            }
            else // If not then pause it
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false); //Disable the UI
        Time.timeScale = 1f; // Set the time to normal
        IsPaused = false; // Game is not paused

    }

    void Pause()
    {
        PauseMenuUI.SetActive(true); // Enable the UI
        Time.timeScale = 0f; // Freeze the time
        IsPaused = true; // Game is paused
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu"); // Go back to menu
        Time.timeScale = 1f; // Unfreeze time
    }

    public void QuitGame() // Quit game
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }
    
  
}
