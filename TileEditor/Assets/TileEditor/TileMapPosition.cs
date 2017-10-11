using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMapPosition : MonoBehaviour, IPosition
{
    public Vector2 getPosition(Vector2 startingPosition)
    {
        Vector2 newPosition = new Vector2(Mathf.Round(startingPosition.x), Mathf.Round(startingPosition.y));
        return newPosition;
    }
}
