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

    private bool isShorted;

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
    }

}
