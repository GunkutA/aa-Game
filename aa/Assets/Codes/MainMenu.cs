using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToGame()
    {
        int savedLevel = PlayerPrefs.GetInt("save");
        if(savedLevel==0)
        {
            SceneManager.LoadScene(savedLevel + 1);
        }
        else
        {
            SceneManager.LoadScene(savedLevel);
        }
    }
}
