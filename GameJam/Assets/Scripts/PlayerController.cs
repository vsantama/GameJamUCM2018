using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float velocity = 20f;
    public KeyCode[] teclas = new KeyCode[4];
	
	// Update is called once per frame
	void Update () {
        Move(velocity);
	}

    void Move(float vel)
    {
        if(Input.GetKey(teclas[0]))
        {
            transform.Translate(-vel * Time.deltaTime, 0, 0, Space.World);
        }
        else if (Input.GetKey(teclas[1]))
        {
            transform.Translate(vel * Time.deltaTime, 0, 0, Space.World);
        }
        if (Input.GetKey(teclas[2]))
        {
            transform.Translate(0, vel * Time.deltaTime, 0, Space.World);
        }
        else if (Input.GetKey(teclas[3]))
        {
            transform.Translate(0, -vel * Time.deltaTime, 0, Space.World);
        }

    }
}
