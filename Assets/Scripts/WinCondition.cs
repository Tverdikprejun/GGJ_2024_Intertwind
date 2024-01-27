using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    [SerializeField]
    private Outlet[] outlets;

    public bool PlayerWon;
    private void Update()
    {
        int winCondition = 0;
        foreach (Outlet outlet in outlets)
        {
            if (outlet.isWinCondition) { winCondition++; }
        }
        if (winCondition == outlets.Length) { PlayerWon = true; }
        else { PlayerWon = false; }
    }
}
