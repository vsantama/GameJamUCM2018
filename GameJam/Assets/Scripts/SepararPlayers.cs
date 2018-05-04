using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SepararPlayers : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject playerSoloPrefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Separar();
	}

    void Separar()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            player1.transform.position = playerSoloPrefab.transform.position / 2;
            Instantiate(player1);
            Instantiate(player2);
            Destroy(playerSoloPrefab);
        }
    }
}
