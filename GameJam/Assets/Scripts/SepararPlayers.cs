using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SepararPlayers : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject playerSolo;
    GameObject mainCamera;
    public bool shiftIzq;
    public bool shiftPressed = false;
    Vector3 pos;


	// Update is called once per frame
	void Update () {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        Separar();
	}

    void Separar()
    {
       /*
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            shiftIzq = true;
            shiftPressed = true;
        }
        else if(Input.GetKeyDown(KeyCode.RightShift)) {
            shiftPressed = true;
        }

        if (shiftPressed)
       */ 
       if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            {

            pos = new Vector3(playerSolo.transform.position.x - 0.8f, playerSolo.transform.position.y, playerSolo.transform.position.z);
            player1.transform.position = pos;

            pos = new Vector3(playerSolo.transform.position.x + 1f, playerSolo.transform.position.y, playerSolo.transform.position.z);
            player2.transform.position = pos;

            GameObject aux = Instantiate(player1);
            mainCamera.BroadcastMessage("addTargetToCamera",aux.transform,SendMessageOptions.DontRequireReceiver);
            aux = Instantiate(player2);
            mainCamera.BroadcastMessage("addTargetToCamera", aux.transform, SendMessageOptions.DontRequireReceiver);
            mainCamera.BroadcastMessage("erasePlayerFromCamera", this.gameObject.transform, SendMessageOptions.DontRequireReceiver);
            Destroy(playerSolo);
        }
    }
}
