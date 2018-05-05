using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour {

    public GameObject[] targetAccion = new GameObject[1];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    virtual public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            act();

        Debug.Log("JAJAJAJAJAJA");
    }
    virtual public void act() {
        for(int i = 0; i< targetAccion.Length; i++)
            targetAccion[i].BroadcastMessage("Activate", SendMessageOptions.RequireReceiver);
    }
}
