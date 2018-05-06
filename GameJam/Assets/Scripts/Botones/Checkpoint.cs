using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {

    int nextLevel;
    private void Start()
    {
        nextLevel = SliderManager.instance.getCurrentLevel() + 1;
    }

    void NextLevel()
    {
        if (SceneManager.GetSceneByName("Nivel" + nextLevel.ToString()) != null)
        {
            SceneManager.LoadScene(nextLevel);
        }
        else SceneManager.LoadScene("MenuInicio");
    }
}
