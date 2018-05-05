using UnityEngine;

public class PlayerSoloController : MonoBehaviour
{

    public float velocity = 20f;
    public KeyCode[] teclas1 = { KeyCode.W, KeyCode.S, KeyCode.D, KeyCode.A };
    public KeyCode[] teclas2 = { KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.RightArrow, KeyCode.LeftArrow };
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        Move(velocity);
    }

    void Move(float vel)
    {
        rb.velocity = new Vector3(0, 0, 0);
        if ((Input.GetKey(teclas1[0]) || Input.GetKey(teclas2[0])))
        {
            //.Translate(0, vel * Time.deltaTime, 0, Space.World);
            rb.velocity = Vector2.up * vel * Time.deltaTime * 50f;
        }
        if ((Input.GetKey(teclas1[1]) || Input.GetKey(teclas2[1])))
        {
            //transform.Translate(0, -vel * Time.deltaTime, 0, Space.World);
            rb.velocity = Vector2.down * vel * Time.deltaTime * 50f;
        }
        if ((Input.GetKey(teclas1[2]) || Input.GetKey(teclas2[2])))
        {
            //transform.Translate(vel * Time.deltaTime, 0, 0, Space.World);
            rb.velocity = Vector2.right * vel * Time.deltaTime * 50f;
        }
        if ((Input.GetKey(teclas1[3]) || Input.GetKey(teclas2[3])))
        {
            //transform.Translate(-vel * Time.deltaTime, 0, 0, Space.World);
            rb.velocity = Vector2.left * vel * Time.deltaTime * 50f;
        }

        //transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * vel);
    }
}
