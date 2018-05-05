using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerManager))]
[RequireComponent (typeof(PlayerController))]

public class LanzarCorazon : MonoBehaviour
{
    PlayerManager Manager;
    PlayerController Controller;

    public GameObject corazon;
    public KeyCode tecla;

    // Use this for initialization
    void Start()
    {
        Manager = GetComponent<PlayerManager>();
        Controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    { 
        Lanzar(Manager);
    }

    void Lanzar(PlayerManager Manager)
    {
        if (Input.GetKeyDown(tecla) && Manager.tieneCorazon)
        {
            corazon.transform.position = transform.position;
            switch(Controller.ultimaTecla)
            {
                case KeyCode.W:
                case KeyCode.UpArrow:
                    corazon.GetComponent<MoverCorazon>().direccion = Vector3.up;
                    break;
                case KeyCode.S:
                case KeyCode.DownArrow:
                    corazon.GetComponent<MoverCorazon>().direccion = Vector3.down;
                    break;
                case KeyCode.D:
                case KeyCode.RightArrow:
                    corazon.GetComponent<MoverCorazon>().direccion = Vector3.right;
                    break;
                case KeyCode.A:
                case KeyCode.LeftArrow:
                    corazon.GetComponent<MoverCorazon>().direccion = Vector3.left;
                    break;
            }
            Instantiate(corazon);
            Manager.tieneCorazon = false;
        }
    }
}
