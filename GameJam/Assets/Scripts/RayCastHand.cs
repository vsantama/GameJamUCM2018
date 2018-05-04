using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastHand : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        ScreenMouseRay();
	}

    public void ScreenMouseRay() {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z - Camera.main.transform.position.z));
        transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2((mousePos.y - transform.position.y), (mousePos.x - transform.position.x)) * Mathf.Rad2Deg);   
    }
}
