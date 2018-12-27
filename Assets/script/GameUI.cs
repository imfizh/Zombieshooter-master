using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : MonoBehaviour
{
    public Slider healthBar;
    public Text scoreText;
    public Text roundText;
    public Text doorText;
    public int round = 1;
    public int playerScore = 0;
    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        AddScore.OnSendScore += UpdateScore;
        RoundController.OnSendRound += UpdateRound;
        Doors.OnSendCost += UpdateCost;
    }
    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        AddScore.OnSendScore -= UpdateScore;
        //HealthSystem.OnSendRound += UpdateRound;
        PlayerPrefs.SetInt("Score", playerScore);
    }
    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
    }
    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        scoreText.text = playerScore.ToString();
    }
    public void UpdateRound(int theRound)
    {
        round += theRound;
        roundText.text = "ROUND: " + round.ToString();    
    }
    public void UpdateCost(int theCost)
    {
        playerScore = playerScore - theCost;
        scoreText.text = playerScore.ToString();
    }
}
