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
        if (Input.GetKeyDown(tecla) && Manager.tieneCorazon)
        {
            Lanzar(Manager);
        }
    }

    void Lanzar(PlayerManager Manager)
    {
        corazon.transform.position = transform.position;
        Instantiate(corazon);
        Manager.tieneCorazon = false;
        
        switch(Controller.ultimaTecla)
        {
            case KeyCode.W:
            case KeyCode.UpArrow:
                corazon.transform.Translate(Vector3.up * Time.deltaTime);
                break;
            case KeyCode.S:
            case KeyCode.DownArrow:
                corazon.transform.position += Vector3.down * Time.deltaTime;
                break;
            case KeyCode.D:
            case KeyCode.RightArrow:
                corazon.transform.position += Vector3.right * Time.deltaTime;
                break;
            case KeyCode.A:
            case KeyCode.LeftArrow:
                corazon.transform.position += Vector3.left * Time.deltaTime;
                break;
        }
    }
}
