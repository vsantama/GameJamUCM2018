using UnityEngine;

public class BotonDoblePulsado : Boton
{

    public GameObject botonGemelo;
    bool otroBoton = false;

    void activarGemelo()
    {
        otroBoton = true;
    }

    override public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            botonGemelo.BroadcastMessage("activarGemelo", SendMessageOptions.RequireReceiver);
            if (otroBoton)
            {
                doStuff("Activate");
            }
        }

        Debug.Log(this.name);
        Debug.Log(otroBoton);
        Debug.Log("JAJAJAJAJAJA");
    }
}
