using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingMenu : MonoBehaviour
{
    public void PlayGame()
    {
        int savedLevel = PlayerPrefs.GetInt("save");
        if (savedLevel == 0)
        {
            SceneManager.LoadScene(savedLevel + 1);
        }
        else
        {
            SceneManager.LoadScene(savedLevel);
        }
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //index 0 is Start Menu and index 1 is Game Scene. So just increase the index from 0 to 1.
    }

    public void QuitGame()
    {
        Debug.Log("Quitted.");
        Application.Quit();
    }
    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings Scene");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Starting Menu");
    }
}
