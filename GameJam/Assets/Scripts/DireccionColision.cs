using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DireccionColision : MonoBehaviour {


    public GameObject player1;
    public GameObject player2;
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Vector3 direccion;
        Vector3 normalizado;
        direccion = player1.transform.position - player2.transform.position;
        normalizado = direccion.normalized;
        Debug.Log(normalizado);
    }
}
