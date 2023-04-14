using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Player.ID = 0;
        for (int i = 0; i < Player.score.Length; i++) // Reset the points from the previous game
            {
                Player.score[i] = 0;
            }
        SceneManager.LoadScene("Mappi 1"); // When starting playing load the first map
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits"); // Load the credits screen when clicking credits on the main menu
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the application when clicking Quit in the main menu
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Main Menu"); // Return back to main menu from other menus
    }
}
