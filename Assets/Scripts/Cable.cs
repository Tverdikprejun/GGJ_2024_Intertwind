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

    private Vector3[] tipsPositions;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        tipsPositions[0] = new Vector3(bottomTip.transform.position.x, bottomTip.transform.position.y, bottomTip.transform.position.z);
        tipsPositions[1] = new Vector3(bottomTip.transform.position.x, bottomTip.transform.position.y, bottomTip.transform.position.z);
        lineRenderer.SetPositions(tipsPositions);
    }

    //public void OnBeginDrag(PointerEventData eventData)
    //{
    //    image.color = new Color(255, 255, 255, 170);
    //}

    //public void OnDrag(PointerEventData eventData)
    //{
    //    rectTransform.anchoredPosition += eventData.delta;
    //    transform.position = Input.mousePosition;
    //}

    //public void OnEndDrag(PointerEventData eventData)
    //{
    //    image.color = new Color(255, 255, 255, 170);
    //}

    //bool canMove;
    //bool dragging;
    //Collider2D collider;
    //void Start()
    //{
    //    collider = GetComponent<Collider2D>();
    //    canMove = false;
    //    dragging = false;
    //}
    //void Update()
    //{
    //    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        if (collider == Physics2D.OverlapPoint(mousePos))
    //        {
    //            canMove = true;
    //        }
    //        else
    //        {
    //            canMove = false;
    //        }
    //        if (canMove) { dragging = true; }
    //    }
    //    if(dragging) { transform.position = mousePos; }
    //    if(Input.GetMouseButtonUp(0)) 
    //    {
    //        canMove = false;
    //        dragging = false;
    //    }
    //}
}
