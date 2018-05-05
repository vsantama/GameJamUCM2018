using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuInicio : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void SkipTut()
    {
        SceneManager.LoadScene("Nivel3");
    }
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
      }
}
