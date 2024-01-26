using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Cable : MonoBehaviour
{

    [SerializeField]
    private CableTip bottomTip;
    
    [SerializeField]
    private CableTip topTip;

    private LineRenderer lineRenderer;

    private EdgeCollider2D edgeCollider;

    public bool isShorted;

    private Cable shortedCable;

    private Vector3[] tipsPositionsVector3 = new Vector3[2];

    private List<Vector2> tipsPositionsVector2 = new List<Vector2>();
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        tipsPositionsVector2 = new List<Vector2>();
        tipsPositionsVector3[0] = new Vector3(bottomTip.transform.position.x, bottomTip.transform.position.y, bottomTip.transform.position.z);
        tipsPositionsVector3[1] = new Vector3(topTip.transform.position.x, topTip.transform.position.y, topTip.transform.position.z);

        lineRenderer.SetPositions(tipsPositionsVector3);

        if (isShorted ) { lineRenderer.SetColors(Color.red, Color.red); }
        else { lineRenderer.SetColors(Color.blue, Color.blue); }
    }
    public float GetStartX()
    {
        Debug.Log(lineRenderer.GetPosition(0).x);
        return lineRenderer.GetPosition(0).x;
    }
    public float GetEndX()
    {
        Debug.Log(lineRenderer.GetPosition(1).x);
        return lineRenderer.GetPosition(1).x;
    }
    public float GetStartY()
    {
        Debug.Log(lineRenderer.GetPosition(0).y);
        return lineRenderer.GetPosition(0).y;
    }
    public float GetEndY()
    {
        Debug.Log(lineRenderer.GetPosition(1).y);
        return lineRenderer.GetPosition(1).y;
    }
}
