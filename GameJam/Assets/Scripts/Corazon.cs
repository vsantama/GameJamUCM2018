using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corazon : MonoBehaviour {

    public SepararPlayers separarScript;
    public Sprite corazon;
    public GameObject corazonManager;
    public PlayerManager manager1;
    public PlayerManager manager2;
    public GameObject[] player = new GameObject[2];

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        if(separarScript.shiftPressed)
        {

            player = GameObject.FindGameObjectsWithTag("Player");
   
            manager1 = player[0].GetComponent<PlayerManager>();
            manager2 = player[1].GetComponent<PlayerManager>();
            separarScript = corazonManager.GetComponent<SepararPlayers>();
            if (separarScript.shiftIzq == true)
            {
                Instantiate(corazon, player[0].transform);
                manager1.tieneCorazon = true;
                manager2.tieneCorazon = false;
            }
            else
            {
                Instantiate(corazon, player[1].transform);
                manager2.tieneCorazon = true;
                manager1.tieneCorazon = false;
            }

            separarScript.shiftPressed = false;
        }
    }
}
