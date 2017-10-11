using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class FindWithRaycast : MonoBehaviour
{
    public Color highlightColor = Color.yellow;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.color = highlightColor;
        spriteRenderer.sortingOrder = 1;
        spriteRenderer.enabled = false;
    }

    void Update()
    {
        float mouseX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        float mouseY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        Vector2 rayPosition = new Vector2(mouseX, mouseY);
        RaycastHit2D hit = Physics2D.Raycast(rayPosition, Vector2.zero, 0f);

        if (hit)
        {
            Debug.Log(hit.transform.name);
            this.transform.position = hit.transform.position;
            spriteRenderer.enabled = true;

        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }
}
