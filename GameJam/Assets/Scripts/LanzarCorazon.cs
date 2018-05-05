using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzarCorazon : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public GameObject corazon;

    public bool shiftIzq;
    public bool shiftPressed = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shiftIzq = true;
            shiftPressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightShift))
        {
            shiftIzq = false;
            shiftPressed = true;
        }

        if (shiftPressed)
        {
            if (shiftIzq && player1.GetComponent<PlayerManager>().tieneCorazon)
            {
                corazon.transform.position = player1.transform.position;
                Debug.Log(player1.transform.position);
                Debug.Log(corazon.transform.position);
                Instantiate(corazon);

                shiftPressed = false;
                shiftIzq = false;
            }
            else if (!shiftIzq && player2.GetComponent<PlayerManager>().tieneCorazon)
            {
                corazon.transform.position = player2.transform.position;
                Debug.Log(player2.transform.position);
                Debug.Log(corazon.transform.position);
                Instantiate(corazon);

                shiftPressed = false;
                shiftIzq = false;
            }
        }
    }
}
