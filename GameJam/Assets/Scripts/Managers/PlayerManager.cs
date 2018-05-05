using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public GameObject jugadorBlanco;
    public GameObject jugadorNegro;
    public bool tieneCorazon = false;

    public bool getHasCorazon() { return tieneCorazon; }
    public void setCorezon(bool hasCorazon) { tieneCorazon = hasCorazon; } //set corezon xDDD

    // Use this for initialization
    void Start () {

        SliderManager.instance.ResetearTiempo();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
