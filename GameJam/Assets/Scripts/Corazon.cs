using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corazon : MonoBehaviour {

    public SepararPlayers separarScript;
    public GameObject corazonManager;
    public PlayerManager manager1;
    public PlayerManager manager2;
    public GameObject player1;
    public GameObject player2;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        if(separarScript.shiftPressed)
        {

            player1 = GameObject.Find("Player1");
            player2 = GameObject.Find("Player2");
            manager1 = player1.GetComponent<PlayerManager>();
            manager2 = player2.GetComponent<PlayerManager>();
            separarScript = corazonManager.GetComponent<SepararPlayers>();
            if (separarScript.shiftIzq == true)
            {
                manager1.tieneCorazon = true;
                manager2.tieneCorazon = false;
            }
            else
            {
                manager2.tieneCorazon = true;
                manager1.tieneCorazon = false;
            }

            separarScript.shiftPressed = false;
        }
    }
}
