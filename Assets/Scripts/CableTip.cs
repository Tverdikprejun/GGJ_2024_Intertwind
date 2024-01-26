using UnityEngine;
using UnityEngine.EventSystems;

public class CableTip : MonoBehaviour , IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private static GameObject objectBeingDragged;
    private Vector3 startPosition;
    private float distanceToCamera;

    private Outlet _currentOutlet;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Here1");

        if (!other.TryGetComponent<Outlet>(out var otherOutlet)) { return; }

        Debug.Log("Here2");

        if (otherOutlet.GetIsOccupied()) 
        {
            Debug.Log("Here3");
            return;
        }

        Debug.Log("Here4");

        _currentOutlet = otherOutlet;
        _currentOutlet.SetCableTip(this);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.TryGetComponent<Outlet>(out _)) { return; }

        if (_currentOutlet == null) { return; }

        _currentOutlet.ResetCableTip();

        _currentOutlet = null;
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        objectBeingDragged = gameObject;
        startPosition = transform.position;
        distanceToCamera = Mathf.Abs(startPosition.z - Camera.main.transform.position.z) - 0.01f;
        objectBeingDragged.layer = LayerMask.NameToLayer("Ignore Raycast");
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        // update position
        objectBeingDragged.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                                                                                            Input.mousePosition.y,
                                                                                            distanceToCamera));
    }

    // called when there has been a drag and the user lets go
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        // check here for "am i close enough to where I'm meant to be"

        // if not "where I'm supposed to be" reset

           // objectBeingDragged.transform.position = startPosition;
        objectBeingDragged.layer = LayerMask.NameToLayer("Default");
        objectBeingDragged = null;
    }
}
