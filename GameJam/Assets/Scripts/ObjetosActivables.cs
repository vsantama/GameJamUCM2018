using UnityEngine;

public class ObjetosActivables : MonoBehaviour {

    protected bool activated = false;

    virtual protected void Activate()
    {
        activated = true;
    }

    virtual protected void Deactivate()
    {
        activated = false;
    }
}
