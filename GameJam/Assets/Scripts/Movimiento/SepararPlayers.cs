using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SepararPlayers : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public GameObject playerSolo;

    public bool shiftIzq;
    public bool shiftPressed = false;

    GameObject mainCamera;
    Vector3 pos;


    void Update()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        Separar();
    }

    void Separar()
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

        //if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        if (shiftPressed)
        {

            pos = new Vector3(playerSolo.transform.position.x - 1f, playerSolo.transform.position.y, playerSolo.transform.position.z);
            player1.transform.position = pos;

            pos = new Vector3(playerSolo.transform.position.x + 1f, playerSolo.transform.position.y, playerSolo.transform.position.z);
            player2.transform.position = pos;

            GameObject aux1 = Instantiate(player1);
            GameObject aux2 = Instantiate(player2);
            Corazon(shiftIzq, aux1, aux2); //Mira quien se queda el corazon (aquel que no haya decidido separarse)

            mainCamera.BroadcastMessage("addTargetToCamera", aux1.transform, SendMessageOptions.DontRequireReceiver);
            mainCamera.BroadcastMessage("addTargetToCamera", aux2.transform, SendMessageOptions.DontRequireReceiver);
            mainCamera.BroadcastMessage("erasePlayerFromCamera", this.gameObject.transform, SendMessageOptions.DontRequireReceiver);

            Destroy(playerSolo);
        }
    }

    void Corazon(bool shiftIzq, GameObject aux1, GameObject aux2)
    {
        if (shiftIzq)
        {
            aux1.GetComponent<PlayerManager>().tieneCorazon = false;
            aux2.GetComponent<PlayerManager>().tieneCorazon = true;
        }
        else
        {
            aux1.GetComponent<PlayerManager>().tieneCorazon = true;
            aux2.GetComponent<PlayerManager>().tieneCorazon = false;
        }
    }
}
