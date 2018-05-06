using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : ObjetosActivables {

    Collider2D col2D;
    SpriteRenderer sp;

    // Use this for initialization
    void Start () {
        activated = false;
        col2D = gameObject.GetComponent<Collider2D>();
        sp = gameObject.GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {

        if (activated)
        {
            col2D.enabled = false;
            sp.enabled = false;
        }
        else if (!activated)
        {
            col2D.enabled = true;
            sp.enabled = true;
        }
    }
}
