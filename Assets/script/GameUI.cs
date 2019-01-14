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
    public static int round1;
    public int playerScore = 0;
    private void Start()
    {
        round1 = 1;
    }
    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        AddScore.OnSendScore += UpdateScore;
        RoundController.OnSendRound += UpdateRound;
        Doors.OnSendCost += UpdateCost;
        GunBuy.OnSendCost1 += UpdateCost;
        UpgradeGun.OnSendCost2 += UpdateCost;
    }
    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        AddScore.OnSendScore -= UpdateScore;
        RoundController.OnSendRound -= UpdateRound;
        Doors.OnSendCost -= UpdateCost;
        GunBuy.OnSendCost1 -= UpdateCost;
        UpgradeGun.OnSendCost2 -= UpdateCost;
        DoublePoints.Dubpoints = false;
        PlayerPrefs.SetInt("Score", round);
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
        round1 = round;
        roundText.text = "ROUND: " + round.ToString();    
    }
    public void UpdateCost(int theCost)
    {
        playerScore = playerScore - theCost;
        scoreText.text = playerScore.ToString();
    }
}
