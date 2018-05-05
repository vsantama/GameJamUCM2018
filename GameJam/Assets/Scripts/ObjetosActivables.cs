using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosActivables : MonoBehaviour {

    protected bool activated = false;

    void Activate()
    {
        activated = true;
    }

    void Deactivate()
    {
        activated = false;
    }
}
