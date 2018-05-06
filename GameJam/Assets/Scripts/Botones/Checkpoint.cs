using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {

    public GameObject sliderMg;
    int nextLevel;
    private void Start()
    {

        nextLevel = SliderManager.instance.getCurrentLevel() + 1;
    }

    void NextLevel()
    {
        Debug.Log(nextLevel);
    }
}
