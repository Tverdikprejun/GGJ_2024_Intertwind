using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Cable : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _interseptionEffectSprite;

    [SerializeField]
    private CableTip bottomTip;
    
    [SerializeField]
    private CableTip topTip;

    private LineRenderer lineRenderer;

    public bool isShorted;

    private Vector3[] tipsPositionsVector3 = new Vector3[2];

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        tipsPositionsVector3[0] = new Vector3(bottomTip.transform.position.x, bottomTip.transform.position.y, bottomTip.transform.position.z);
        tipsPositionsVector3[1] = new Vector3(topTip.transform.position.x, topTip.transform.position.y, topTip.transform.position.z);

        lineRenderer.SetPositions(tipsPositionsVector3);

        if (isShorted ) 
        {
            _interseptionEffectSprite.enabled = true;
            _interseptionEffectSprite.transform.position = new Vector3(GetMiddleX(), GetMiddleY(), topTip.transform.position.z);
        }
        else 
        {
            _interseptionEffectSprite.enabled = false;
            /*lineRenderer.SetColors(Color.blue, Color.blue);*/ 
        }
    }
    public float GetStartX()
    {
        return lineRenderer.GetPosition(0).x;
    }
    public float GetEndX()
    {
        return lineRenderer.GetPosition(1).x;
    }
    public float GetStartY()
    {
        return lineRenderer.GetPosition(0).y;
    }
    public float GetEndY()
    {
        return lineRenderer.GetPosition(1).y;
    }
    private float GetMiddleX()
    {
        return (GetEndX() + GetStartX())/2;
    }
    private float GetMiddleY()
    {
        return (GetEndY() + GetStartY())/2;
    }
}
