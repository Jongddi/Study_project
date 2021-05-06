using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideObject : MonoBehaviour
{
    public bool isSafe;
    public bool isLog;
    public bool isTurtle;
    public bool isHomeBay;
    public bool isOccupied = false;

    Rect playerRect;
    Vector2 playerSize;
    Vector2 playerPosition;
    Rect collideObjectRect;
    Vector2 collideObjectSize;
    Vector2 collideObjectPosition;
    public bool Colliding (GameObject playerObject)
    {
        playerSize = playerObject.transform.GetComponent<SpriteRenderer>().size;
        playerPosition = playerObject.transform.localPosition;
        collideObjectSize = GetComponent<SpriteRenderer>().size;
        collideObjectPosition = transform.localPosition;
        playerRect = new Rect(playerPosition.x - playerSize.x / 2, playerPosition.y - playerSize.y / 2, playerSize.x, playerSize.y);
        collideObjectRect = new Rect(collideObjectPosition.x - collideObjectSize.x / 2, collideObjectPosition.y - collideObjectSize.y / 2, collideObjectSize.x, collideObjectSize.y);

        if (collideObjectRect.Overlaps(playerRect, true))
        {
            return true;
        }
        return false;
    }
}
