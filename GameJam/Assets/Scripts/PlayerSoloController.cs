using UnityEngine;

public class PlayerSoloController : MonoBehaviour
{

    public float velocity = 20f;
    public KeyCode[] teclas1 = { KeyCode.W, KeyCode.S, KeyCode.D, KeyCode.A };
    public KeyCode[] teclas2 = { KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.RightArrow, KeyCode.LeftArrow };
    Vector3 pos;

    void Start()
    {
        pos = transform.position;
    }
    
    void Update()
    {
        Move(velocity);
    }

    void Move(float vel)
    {
        if (Input.GetKey(teclas1[0]) && Input.GetKey(teclas2[0]) && transform.position == pos)
        {
            //.Translate(0, vel * Time.deltaTime, 0, Space.World);
            pos += Vector3.up;
        }
        else if (Input.GetKey(teclas1[1]) && Input.GetKey(teclas2[1]) && transform.position == pos)
        {
            //transform.Translate(0, -vel * Time.deltaTime, 0, Space.World);
            pos += Vector3.down;
        }
        if (Input.GetKey(teclas1[2]) && Input.GetKey(teclas2[2]) && transform.position == pos)
        {
            //transform.Translate(vel * Time.deltaTime, 0, 0, Space.World);
            pos += Vector3.right;
        }
        else if (Input.GetKey(teclas1[3]) && Input.GetKey(teclas2[3]) && transform.position == pos)
        {
            //transform.Translate(-vel * Time.deltaTime, 0, 0, Space.World);
            pos += Vector3.left;
        }

        transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * vel);
    }
}
