using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuntarPlayers : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject playerSoloPrefab;

	// Use this for initialization
	void Start () {
		//Asignar automaticamente el GO
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION");
        //PASAR DATOS DE PLAYER 1 A PLAYER 2
        playerSoloPrefab.transform.position = (player1.transform.position + player2.transform.position) / 2;
        Destroy(player1);
        Destroy(player2);
        Instantiate(playerSoloPrefab);
    }
}
