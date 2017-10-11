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
        Vector2 mousePosition = new Vector2(mouseX, mouseY);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, 0f);

        if (hit)
        {
            IPosition[] positionList = hit.transform.gameObject.GetComponents<IPosition>();

            if (positionList.Length > 0)
            {
                IPosition position = positionList[0];
                this.transform.position = position.getPosition(mousePosition);
            }
            else
            {
                this.transform.position = hit.transform.position;
            }

            spriteRenderer.enabled = true;

        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }
}
