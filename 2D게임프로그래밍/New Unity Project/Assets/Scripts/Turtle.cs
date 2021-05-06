using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour
{

    public enum TurtleType
    {
        TurtleFloating,
        TurtleDiving
    };

    public TurtleType turtleType = TurtleType.TurtleFloating;

    public Sprite turtleDiveSprite;
    public Sprite turtleFloatSprite;

    public float speed = 5.0f;
    public bool moveRight = true;

    private readonly float playAreaWidth = 19.0f;

    public bool sDive = false, sSurface = true, dDive = false, dSurface = false;
    private float surfaceTime = 5f;
    private float diveTime = 5f;
    private float surfaceTimer;
    private float diveTimer;
    private float transitionTime = 5f;
    private float transitionTimer;

    void Update()
    {
        UpdateTurtlePosition();
        UpdateDiveTurtleStatus();
    }

    void UpdateTurtlePosition()
    {
        Vector2 pos = transform.localPosition; 
        if (moveRight)
        {
            pos.x += speed * Time.deltaTime;
            if (pos.x >= ((playAreaWidth / 2) - 1) + (playAreaWidth - 1) - GetComponent<SpriteRenderer>().size.x / 2)
            {
                pos.x = -playAreaWidth / 2 - GetComponent<SpriteRenderer>().size.x / 2;
            }
        }
        else
        {
            pos.x -= speed * Time.deltaTime;

            if (pos.x <= ((-playAreaWidth / 2) + 1) - (playAreaWidth - 1) + GetComponent<SpriteRenderer>().size.x / 2)
            {
                pos.x = playAreaWidth / 2 + GetComponent<SpriteRenderer>().size.x / 2;
            }
        }

        transform.localPosition = pos;
    }

    void UpdateDiveTurtleStatus()
    {
        if (turtleType == TurtleType.TurtleDiving)
        {
            if (sSurface == true) 
            {
                transitionTimer += Time.deltaTime; 

                if (transitionTimer >= transitionTime) 
                {
                    sSurface = false;
                    transitionTimer = 0; 
                    dSurface = true;
                    GetComponent<SpriteRenderer>().sprite = turtleFloatSprite; 
                }
            }

            if (dSurface == true)
            {
                surfaceTimer += Time.deltaTime;
                if (surfaceTimer >= surfaceTime)
                {
                    dSurface = false;
                    surfaceTimer = 0; 
                    GetComponent<SpriteRenderer>().sprite = turtleDiveSprite;
                    sDive = true;
                }
            }

            if (sDive == true)
            {
                transitionTimer += Time.deltaTime;

                if (transitionTimer >= transitionTime)
                {
                    sDive = false;
                    dDive = true;
                    transitionTimer = 0;
                    GetComponent<SpriteRenderer>().enabled = false;
                    GetComponent<CollideObject>().isSafe = false;
                }
            }

            if (dDive == true)
            {
                diveTimer += Time.deltaTime;

                if (diveTimer >= diveTime)
                {
                    dDive = false;
                    sSurface = true;
                    diveTimer = 0;
                    GetComponent<SpriteRenderer>().sprite = turtleDiveSprite;
                    GetComponent<CollideObject>().isSafe = true;
                    GetComponent<SpriteRenderer>().enabled = true;
                }
            }
        }
    }
}
