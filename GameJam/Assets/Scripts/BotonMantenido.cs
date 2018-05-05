using UnityEngine;

public class BotonMantenido : Boton {

    virtual protected void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
            doStuff("Deactivate");
    }
}
