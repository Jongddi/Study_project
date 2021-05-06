using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{

    public Image life1, life2, life3, life4;
    public Text scoreText;
    public Text Clear;
    public Text Restart;
    void Start()
    {
        HideWin();
    }

    public void UpdatePlayerLives(int playerHealth)
    {
        switch (playerHealth)
        {
            case 4:
                life1.enabled = true;
                life2.enabled = true;
                life3.enabled = true;
                life4.enabled = true;
                break;
            case 3:
                life1.enabled = true;
                life2.enabled = true;
                life3.enabled = true;
                life4.enabled = false;
                break;
            case 2:
                life1.enabled = true;
                life2.enabled = true;
                life3.enabled = false;
                life4.enabled = false;
                break;
            case 1:
                life1.enabled = true;
                life2.enabled = false;
                life3.enabled = false;
                life4.enabled = false;
                break;
            case 0:
                life1.enabled = false;
                life2.enabled = false;
                life3.enabled = false;
                life4.enabled = false;
                break;
        }
    }

    public void UpdatePlayerScore (int score)
    {
    
        int currentScore = int.Parse(scoreText.text);
        currentScore += score;
        scoreText.text = currentScore.ToString();
    }

    public void ResetPlayerScore()
    {
        scoreText.text = "0";
    }

    public void ShowWin()
    {
        Clear.enabled = true;
        Restart.enabled = true;
    }

    public void HideWin()
    {
        Clear.enabled = false;
        Restart.enabled = false;
    }
}
