using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private int gameSceneIndex =2;

    public void PlayGame()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}