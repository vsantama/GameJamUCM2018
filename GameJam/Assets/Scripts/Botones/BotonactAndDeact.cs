using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonactAndDeact : Boton {

    public GameObject[] targetDeact = new GameObject[1];

    override public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (targetAccion.Length == 0)
                targetAccion[0] = other.gameObject;

            doStuff("Activate",targetAccion);
            doStuff("Deactivate", targetDeact);
        }
    }

    virtual public void doStuff(string stuff, GameObject[] target)
    {
        for (int i = 0; i < target.Length; i++)
            target[i].BroadcastMessage(stuff, SendMessageOptions.RequireReceiver);
    }
}
