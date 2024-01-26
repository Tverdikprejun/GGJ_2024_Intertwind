using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private int gameSceneIndex = 0 ;

    public void PlayGame()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }
  
    public void ExitGame()
    {
        Application.Quit();
    }

}