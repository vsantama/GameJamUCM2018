using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuntarPlayers : MonoBehaviour {

    public GameObject playerSolo;
    GameObject mainCamera;
    Vector3 direccion;
    public Vector3 normalizado;

    // Use this for initialization
    void Start () {
		mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {

        direccion = gameObject.transform.position - collision.gameObject.transform.position;
        normalizado = direccion.normalized; //DIRECION EN LA QUE CHOCAN

        // Mensajes para la camara
        mainCamera.BroadcastMessage("erasePlayerFromCamera", this.gameObject.transform, SendMessageOptions.DontRequireReceiver);
        mainCamera.BroadcastMessage("erasePlayerFromCamera", collision.transform, SendMessageOptions.DontRequireReceiver);
        

        //PASAR DATOS DE PLAYER 1 A PLAYER 2
        playerSolo.transform.position = (gameObject.transform.position + collision.gameObject.transform.position) / 2;
        Destroy(this.gameObject);
        Destroy(collision.gameObject);
        GameObject aux = Instantiate(playerSolo);
        mainCamera.BroadcastMessage("addTargetToCamera", aux.transform, SendMessageOptions.DontRequireReceiver);
    }
}
