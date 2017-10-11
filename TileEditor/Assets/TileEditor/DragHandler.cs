using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector2 startPosition;
    Transform startParent;


    public void OnBeginDrag(PointerEventData eventData)
    {

        itemBeingDragged = transform.GetChild(0).gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
        itemBeingDragged = null;
        Debug.Log(transform.parent.name);
    }
}
