using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SepararPlayers : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject playerSolo;

    Vector3 pos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Separar();
	}

    void Separar()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
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
