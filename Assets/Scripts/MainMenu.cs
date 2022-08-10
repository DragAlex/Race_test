using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text HightScore;
    public float Score;
    void Start()
    {
        if (PlayerPrefs.HasKey("HightScore"))
        {
            Score = PlayerPrefs.GetFloat("HightScore");
            HightScore.text = "Лучшее время: " + Score;
        }

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

   /* 
    public void Exit()
    {
    }
   */
}
