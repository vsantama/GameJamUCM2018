using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroPlano : MonoBehaviour {
    //Añadir esto a el gameObjet a girar
    Vector3 giro = new Vector3(0, 0, 90); //Girar 90 en Y

	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Q))
       this.transform.Rotate(giro);
	}
}
