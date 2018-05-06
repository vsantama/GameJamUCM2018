using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Checkpoint : ObjetosActivables {

    public bool player1;
    public Vector3 posicionCheckpoint;
    // Use this for initialization
    private void Update()
    {
        if(activated && !player1)
        {
            int nextLevel = SliderManager.instance.CurrentLevel + 1;

            SceneManager.LoadScene("Nivel" + nextLevel); 
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        player1 = (collision.tag == "2DPlayer1");
    }
}
