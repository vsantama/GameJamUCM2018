using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float velocity = 15f;
    public KeyCode[] teclas = new KeyCode[4];
    Vector3 pos;

    void Start()
    {
        pos = transform.position;
    }
    // Update is called once per frame
    void Update () {
        Move(velocity);
	}

    void Move(float vel)
    {
        if (Input.GetKey(teclas[0]) && transform.position == pos)
        {
            //transform.Translate(0, vel * Time.deltaTime, 0, Space.World);
            pos += Vector3.up;
        }
        else if (Input.GetKey(teclas[1]) && transform.position == pos)
        {
            //transform.Translate(0, -vel * Time.deltaTime, 0, Space.World);
            pos += Vector3.down;
        }
        if (Input.GetKey(teclas[2]) && transform.position == pos)
        {
            //transform.Translate(vel * Time.deltaTime, 0, 0, Space.World);
            pos += Vector3.right;
        }
        else if(Input.GetKey(teclas[3]) && transform.position == pos)
        {
            //transform.Translate(-vel * Time.deltaTime, 0, 0, Space.World);
            pos += Vector3.left;
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * vel);
    }
}
