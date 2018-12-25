using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour {

    public delegate void SendScore(int theScore);
    public static event SendScore OnSendScore;
    public int score = 10;
    public int DeathScore = 80;
    private bool scoreSent = false;
    public void OnAddScore()
    {
        if (OnSendScore != null)
        {
            if (!scoreSent)
            {
                if (DoublePoints.Dubpoints == true)
                {
                    OnSendScore(DeathScore * 2);
                }
                scoreSent = true;
                OnSendScore(DeathScore);
            }
        }
    }
        public void Points()
    {
        if (DoublePoints.Dubpoints == true)
        {
            OnSendScore(score * 2);
        }
        OnSendScore(score);
    }
}
