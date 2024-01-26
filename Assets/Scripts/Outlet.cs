using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outlet : MonoBehaviour
{
    [SerializeField] private bool isOccupiedOnStartup;

    private bool IsOccupied;

    private void Start()
    {
        IsOccupied = isOccupiedOnStartup;
    }
}
