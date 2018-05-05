using UnityEngine;

public class Boton : MonoBehaviour {

    public GameObject[] targetAccion = new GameObject[1];


    virtual public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (targetAccion.Length == 0)
                targetAccion[0] = other.gameObject;

            doStuff("Activate");
        }

        Debug.Log("JAJAJAJAJAJA");
    }
    virtual public void doStuff(string stuff) {
        for(int i = 0; i< targetAccion.Length; i++)
            targetAccion[i].BroadcastMessage(stuff, SendMessageOptions.RequireReceiver);
    }

    virtual public void doStuff(string stuff, GameObject obj)
    {
        obj.BroadcastMessage(stuff, SendMessageOptions.RequireReceiver);
    }
}
