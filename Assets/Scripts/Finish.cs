using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Rigidbody rb;
    public Timer timer;
    public PauseMenu pauseMenu;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        timer.SaveScore();
        pauseMenu.MainMenu();
    }
}
