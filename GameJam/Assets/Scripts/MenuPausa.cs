using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour {

    public static bool pausado = false;
    public GameObject menuPauseUI;
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        menuPauseUI.SetActive(true);
        Time.timeScale = 0f;
        pausado = true;
    }
    public void Resume()
    {
        menuPauseUI.SetActive(false);
        Time.timeScale = 1f;
        pausado = false;
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
