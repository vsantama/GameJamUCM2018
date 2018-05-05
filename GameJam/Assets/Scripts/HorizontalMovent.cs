using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovent : ObjetosActivables {

    public float vel = 10;
    Vector3 pos;

	// Use this for initialization
	void Start () {
        pos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		if (activated)
        {
            pos += Vector3.right;
            transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * vel);
        }
	}
}
