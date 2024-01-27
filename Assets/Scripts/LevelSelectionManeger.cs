using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectionManeger : MonoBehaviour
{
    public void LoadScene(int LevelIndex)
    {
        SceneManager.LoadScene(LevelIndex);
    }
}