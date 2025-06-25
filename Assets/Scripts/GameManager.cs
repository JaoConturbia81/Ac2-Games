using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 0;
    
    public TMP_Text scoreText;
    public TMP_Text livesText;

    public void AddPoints(int quantidade)
    {
        score += quantidade;
        UpdateHUD();
    }

    public void RemoveLife()
    {
        lives--;
        UpdateHUD();
    }

    public void Heal()
    {
        lives++;
        UpdateHUD();
    }

    public void UpdateHUD()
    {
        livesText.text = "Vida: " + lives;
        scoreText.text = "Pontos: " + score;
    }
}
