using UnityEngine;
using UnityEngine.SceneManagement;
public class BotonDoblePulsado : Boton
{

    public GameObject botonGemelo;
    protected bool otroBoton = false;

    virtual protected void activarGemelo()
    {
        otroBoton = true;
    }

    virtual protected void desactivarGemelo()
    {
        otroBoton = false;
    }

    override public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            botonGemelo.BroadcastMessage("activarGemelo", SendMessageOptions.RequireReceiver);
            if (otroBoton)
            {
                doStuff(stuff);
            }
        }

        Debug.Log(this.name);
        Debug.Log(stuff);
        Debug.Log(otroBoton);
        Debug.Log("JAJAJAJAJAJA");
    }
}
