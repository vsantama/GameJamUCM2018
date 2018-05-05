using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonDobleMantenido : BotonDoblePulsado {

    virtual public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            botonGemelo.BroadcastMessage("desactivarGemelo", SendMessageOptions.RequireReceiver);
            if (otroBoton)
            {
                doStuff("Deactivate");
            }
        }

        Debug.Log(this.name);
        Debug.Log(otroBoton);
        Debug.Log("JAJAJAJAJAJA");
    }
}
