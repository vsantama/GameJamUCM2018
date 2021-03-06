using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroMovimiento : ObjetosActivables {

    bool movido = true;
    public Vector3 movimiento; //Asignar vector individualmente por cada puerta
    Vector3 posIni;
    private void Start()
    { 
        posIni = gameObject.transform.position;
    }
    void Update () {
        if (activated)
        {
            if (movido)
            {

            //this.gameObject.transform.Translate((posIni + movimiento) * Time.deltaTime, Space.World);
            gameObject.transform.position = posIni + movimiento;
                movido = false;
            }
        }
        
        else if (!activated)
        {
            //this.gameObject.transform.Translate(posIni * Time.deltaTime, Space.World);
            gameObject.transform.position = posIni;
            movido = true;
        }
        
	}
}
