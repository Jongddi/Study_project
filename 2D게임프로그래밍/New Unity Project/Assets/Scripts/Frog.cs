using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public Sprite frogUp, frogDown, frogLeft, frogRight;
    public int life = 4;
    private Vector2 originalPosition;
    private Interface UI;
    private int maxY = 0, currentY = 1;
    private int numFrogsInBays = 0;
    private bool gameWin = false;

    void Start()
    {
        originalPosition = transform.localPosition;

        UI = GameObject.Find("UI").GetComponent<Interface>();

        GameReset();
    }

    void Update()
    {
        UpdatePosition();
        CheckCollisions();
        CheckPlayAgain();
    }

    private void CheckPlayAgain()
    {
        if (gameWin == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameWin = false;
                UI.HideWin();
                GameReset();
            }
        }
    }

    private void UpdatePosition()
    {
        if (!gameWin)
        {
                Vector2 pos = transform.localPosition;
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    GetComponent<SpriteRenderer>().sprite = frogUp;
                    pos += Vector2.up;
                    if (currentY > maxY)
                    {
                        UI.UpdatePlayerScore(10);

                        maxY = currentY;
                    }
                    currentY++; 
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    GetComponent<SpriteRenderer>().sprite = frogDown;

                    if (pos.y > -6)
                    {
                        pos += Vector2.down;

                        currentY--;

                    }
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    GetComponent<SpriteRenderer>().sprite = frogLeft;

                    if (pos.x > -8)
                    {
                        pos += Vector2.left;


                    }
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    GetComponent<SpriteRenderer>().sprite = frogRight;

                    if (pos.x < 8)
                    {
                        pos += Vector2.right; 

                    }
                }
                transform.localPosition = pos;
        }
    }

    private void CheckCollisions()
    {
        bool isSafe = true;
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("CollidableObject");

        foreach (GameObject go in gameObjects) 
        {
            CollideObject colliedObject = go.GetComponent<CollideObject>();

            if (colliedObject.Colliding(this.gameObject)) 
            {
                if (colliedObject.isSafe)
                {
                    isSafe = true;

                    if (colliedObject.isLog)
                    {
                        Vector2 pos = transform.localPosition;

                        if (colliedObject.GetComponent<Log>().moveRight)
                        {
                            pos.x += colliedObject.GetComponent<Log>().moveSpeed * Time.deltaTime; 

                            if (transform.localPosition.x >= 9.5f) 
                            {
                                pos.x = transform.localPosition.x - 18f; 
                            }
                        }
                        else
                        {
                            pos.x -= colliedObject.GetComponent<Log>().moveSpeed * Time.deltaTime;

                            if (transform.localPosition.x <= -9.5f)
                            {
                                pos.x = transform.localPosition.x + 18f;
                            }
                        }
                        transform.localPosition = pos; 
                    }
                    else if (colliedObject.isTurtle)
                    {
                        Vector2 pos = transform.localPosition; 
                        if (colliedObject.GetComponent<Turtle>().moveRight) 
                        {
                            pos.x += colliedObject.GetComponent<Turtle>().speed * Time.deltaTime;
                           
                            if (transform.localPosition.x > 9.5f)
                            {
                                pos.x = transform.localPosition.x - 18f;
                            }
                        }
                        else 
                        {
                            pos.x -= colliedObject.GetComponent<Turtle>().speed * Time.deltaTime;

                            if (transform.localPosition.x <= -9.5f)
                            {
                                pos.x = transform.localPosition.x + 18f;
                            }
                        }
                        transform.localPosition = pos; 
                    }
                    else if (colliedObject.isHomeBay)
                    {
                        if (!colliedObject.isOccupied)
                        {
                            GameObject trophy = (GameObject)Instantiate(Resources.Load("Prefabs/trophy", typeof(GameObject)), colliedObject.transform.localPosition, Quaternion.identity);
                            trophy.tag = "Trophy";

                            UI.UpdatePlayerScore(50);

                            colliedObject.isOccupied = true;

                            numFrogsInBays++;

                            if (numFrogsInBays == 5)
                            {
                                GameWin();
                            }
                        }
                        ResetPosition();
                    }
                    break;
                }
                else
                {
                    isSafe = false;
                }
            }
        }
        if (!isSafe)
        {
            if (life == 0)
            {
                GameOver();
            }
            else
            {
                PlayerDied();
            }
        }
    }

    void PlayerDied()
    {
        DecreaseHealth();
        ResetPosition();
    }

    void DecreaseHealth()
    {
        life -= 1;
    }

    void GameOver()
    {
        GameReset();
    }

    void GameReset()
    {
        life = 4;
        ResetPosition();
        GetComponent<SpriteRenderer>().enabled = true;
        numFrogsInBays = 0;
        RemoveTrophies();
    }

    void GameWin()
    {
        UI.ShowWin();
        gameWin = true;
        GetComponent<SpriteRenderer>().enabled = true;
    }

    void RemoveTrophies()
    {
        GameObject[] trophies;
        trophies = GameObject.FindGameObjectsWithTag("Trophy");
        foreach (GameObject trophy in trophies)
        {
            Destroy(trophy.gameObject);
        }
    }

    void ResetPosition()
    {
        UI.UpdatePlayerLives(life);

        transform.localPosition = originalPosition;
        transform.GetComponent<SpriteRenderer>().sprite = frogUp;
        maxY = 0;
        currentY = 1;
    }
}
