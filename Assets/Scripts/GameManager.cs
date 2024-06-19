using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    public TMP_Text scoreText;

    public void AddScore(int value)
    {
        score += value;
        UpdateScore();
    }

   public void UpdateScore()
   {
        scoreText.text = "Score : " + score.ToString();
   }
}
