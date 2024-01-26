using System;
using UnityEngine;

public class Outlet : MonoBehaviour
{
    private CableTip _currentCableTip = null;

    public bool GetIsOccupied() => _currentCableTip != null;

    public void SetCableTip(CableTip cableTip)
    {
        _currentCableTip = cableTip;
    }

    public void ResetCableTip() { _currentCableTip = null; }
}