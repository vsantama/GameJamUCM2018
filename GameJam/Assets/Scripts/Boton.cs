using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour {

    public GameObject[] targetAccion = new GameObject[1];

	// Use this for initialization
	virtual protected void Start () {
		
	}
	
	// Update is called once per frame
	virtual protected void Update () {
		
	}

    virtual public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            doStuff("Activate");

        Debug.Log("JAJAJAJAJAJA");
    }
    virtual public void doStuff(string stuff) {
        for(int i = 0; i< targetAccion.Length; i++)
            targetAccion[i].BroadcastMessage(stuff, SendMessageOptions.RequireReceiver);
    }
}
