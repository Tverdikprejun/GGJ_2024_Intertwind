using System;
using UnityEngine;

public class Outlet : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _renderer;

    [SerializeField]
    private Sprite occupiedSprite;

    [SerializeField]
    private Sprite nonOccupiedSprite;

    private CableTip _currentCableTip = null;


    public bool GetIsOccupied() => _currentCableTip != null;

    public void SetCableTip(CableTip cableTip)
    {
        _currentCableTip = cableTip;
        ChangeSprite(true);
    }

    public void ResetCableTip() 
    { 
        _currentCableTip = null;
        ChangeSprite(false);
    }

    private void ChangeSprite(bool isOccupied)
    {
        _renderer.sprite = isOccupied ? occupiedSprite : nonOccupiedSprite;
    }
}