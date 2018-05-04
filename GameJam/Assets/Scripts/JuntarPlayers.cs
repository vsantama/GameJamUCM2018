using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuntarPlayers : MonoBehaviour {

    public GameObject player1;
    public GameObject playerSolo;

	// Use this for initialization
	void Start () {
		//Asignar automaticamente el GO
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {

        //PASAR DATOS DE PLAYER 1 A PLAYER 2
        playerSolo.transform.position = (player1.transform.position + collision.gameObject.transform.position) / 2;
        Destroy(player1);
        Destroy(collision.gameObject);
        Instantiate(playerSolo);
    }
}
