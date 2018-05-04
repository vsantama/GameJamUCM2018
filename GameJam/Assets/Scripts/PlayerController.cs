using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float velocity = 20f;
	
	// Update is called once per frame
	void Update () {
        Move(velocity);
	}

    void Move(float vel)
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-vel * Time.deltaTime, 0, 0, Space.World);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(vel * Time.deltaTime, 0, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, vel * Time.deltaTime, 0, Space.World);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -vel * Time.deltaTime, 0, Space.World);
        }

    }
}
