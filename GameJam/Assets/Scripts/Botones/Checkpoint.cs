using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {

    int nextLevel;
    private void Start()
    {
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void NextLevel()
    {
        if (SceneManager.GetSceneByBuildIndex(nextLevel) != null)
        {
            SceneManager.LoadScene(nextLevel);
        }
        else SceneManager.LoadScene("MenuInicio");
    }
}
