using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCorazon : MonoBehaviour {

    public Vector3 direccion = new Vector3(0, 0, 0);
    public float vel = 6f;
    public Rigidbody2D rb;

	void Start () {
		
	}
	
	void Update () {
        //transform.Translate(direccion * vel * Time.deltaTime);
        rb.velocity = direccion * vel * Time.deltaTime * 50f;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<PlayerManager>().tieneCorazon = true;
        }
    }
}