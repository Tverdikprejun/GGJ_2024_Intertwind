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

    [SerializeField]
    public string color;

    public bool GetIsOccupied() => _currentCableTip != null;

    private void Start()
    {
        if(color == "blue")
        {
            _renderer.color = new Color(65, 160, 255);
        }else if(color == "red")
        {
            _renderer.color = new Color(65, 160, 255);
        }
    }
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