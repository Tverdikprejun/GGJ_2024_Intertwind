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

    private Vector3[] tipsPositions = new Vector3[2];
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        tipsPositions[0] = new Vector3(bottomTip.transform.position.x, bottomTip.transform.position.y, bottomTip.transform.position.z);
        tipsPositions[1] = new Vector3(topTip.transform.position.x, topTip.transform.position.y, topTip.transform.position.z);
        lineRenderer.SetPositions(tipsPositions);
    }
}
