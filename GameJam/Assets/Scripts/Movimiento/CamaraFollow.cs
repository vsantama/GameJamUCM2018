using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour {

    public Transform target;
	// Update is called once per frame
	void LateUpdate () {
        Vector3 newPos = target.position;
        newPos.z = transform.position.z;
        transform.position = newPos;
		
	}
}
