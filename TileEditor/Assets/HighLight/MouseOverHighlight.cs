using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class MouseOverHighlight : MonoBehaviour
{

    public Color highlightColor = Color.yellow;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.color = highlightColor;
        spriteRenderer.sortingOrder = 1;
        spriteRenderer.enabled = false;
    }

    void OnMouseEnter()
    {
        spriteRenderer.enabled = true;
    }
    void OnMouseExit()
    {
        spriteRenderer.enabled = false;
    }
}
