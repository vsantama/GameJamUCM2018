﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonMantenido : Boton {

    virtual protected void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            doStuff("Deactivate");
    }
}