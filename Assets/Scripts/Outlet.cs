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

    public bool GetIsOccupied()
    {
        if(_currentCableTip != null &&_currentCableTip.color == color)return true;
        else return false;
    }

    private void Start()
    {
        Color blue = new Color32(65, 160, 255,255);
        Color red = new Color32(255, 75, 65, 255);
        Color magenta = new Color32(255, 40, 255, 255);
        if (color == "blue")
        {
            _renderer.color = blue;
        }else if(color == "red")
        {
            _renderer.color = red;
        }else if(color == "magenta")
        {
            _renderer.color = magenta;
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