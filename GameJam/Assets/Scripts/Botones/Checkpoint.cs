using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Checkpoint : ObjetosActivables {

    int nextLevel;
    public bool player1;
    private void Start()
    {  
      nextLevel = SliderManager.instance.CurrentLevel + 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(nextLevel);
        SceneManager.LoadScene("Nivel" + nextLevel);
    }
}
