using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slingshot slingshot;
    public Player player;
    public Finish finish;
    public Vector3 playerPos, finishPos;
    private int sec, sec2;
    private float power, dist, maxDist;
    private float HighScore;
    private float Score;
    public Text TimerText;
    public Text ProgressText;
    public Text PowerText;

    private void Start()
    {
        playerPos = player.rb.position;
        finishPos = finish.rb.position;
        HighScore = PlayerPrefs.GetFloat("HightScore", 99999f);
        maxDist = (playerPos - finishPos).magnitude;
    }
    void Update()
    {
        playerPos = player.rb.position;
        dist = (playerPos - finishPos).magnitude;
        power = slingshot.GetDistance() * 100;
        sec = (int)(Time.timeSinceLevelLoad);
        sec2 = (int)(Time.timeSinceLevelLoad * 10000f) % 10000;
        Score = sec + (float)sec2 / 10000;
        TimerText.text = "Время: " + Score;
        ProgressText.text = "Пройдено: " + (100f - Mathf.Round(dist / maxDist * 100)) + "%";
        PowerText.text = "Сила натяжения: " + Mathf.Round(power) + "%";

    }
    public void SaveScore()
    {
        if (Score < HighScore)
            HighScore = Score;
        PlayerPrefs.SetFloat("HightScore", HighScore);
        PlayerPrefs.Save();
    }
}
