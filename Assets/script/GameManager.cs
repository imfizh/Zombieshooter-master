using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("zombie shooter");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("end screen");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("start screen");
    }
}
