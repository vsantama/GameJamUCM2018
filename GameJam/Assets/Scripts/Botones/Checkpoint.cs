using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : ObjetosActivables {

    public Vector3 posicionCheckpoint;
	// Use this for initialization
	void Start () {
        posicionCheckpoint = gameObject.transform.position;
	}
	
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
    }
}
