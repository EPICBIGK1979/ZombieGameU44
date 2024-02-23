using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour //This is the public class for my main menu
{
    public void PlayGame() //Public void for playing the game
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame() //Public quit game
    {
        Application.Quit();
    }
}
