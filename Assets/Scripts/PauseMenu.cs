using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject Menu;

    public void Resume()
    {
        Menu.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void Pause()
    {
        Menu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
