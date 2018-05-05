using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SepararPlayers : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject playerSolo;
    public bool shiftIzq;
    public bool shiftPressed = false;
    Vector3 pos;


	// Update is called once per frame
	void Update () {
        Separar();
	}

    void Separar()
    {
       
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shiftIzq = true;
            shiftPressed = true;
        }
        else if(Input.GetKeyDown(KeyCode.RightShift)) {
            shiftPressed = true;
        }

        if (shiftPressed)
        {

            pos = new Vector3(playerSolo.transform.position.x - 0.8f, playerSolo.transform.position.y, playerSolo.transform.position.z);
            player1.transform.position = pos;

            pos = new Vector3(playerSolo.transform.position.x + 0.8f, playerSolo.transform.position.y, playerSolo.transform.position.z);
            player2.transform.position = pos;

            Instantiate(player1);
            Instantiate(player2);

            Destroy(playerSolo);
        }
    }
}
