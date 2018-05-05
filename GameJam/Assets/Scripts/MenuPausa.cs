using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject menuPauseUI;
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Resume()
    {
        menuPauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        menuPauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
