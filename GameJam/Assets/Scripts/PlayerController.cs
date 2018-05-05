using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float velocity = 15f;
    public KeyCode[] teclas = new KeyCode[4];
    Vector3 pos;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pos = transform.position;
    }
    // Update is called once per frame
    void FixedUpdate () {
        Move(velocity);
    }

    void Move(float vel)
    {
        rb.velocity =new  Vector3(0, 0, 0);

        if (Input.GetKey(teclas[0]))
        {
            //transform.Translate(0, vel * Time.deltaTime, 0, Space.World);
            //pos += Vector3.up;
            rb.velocity = Vector2.up * vel * Time.deltaTime * 50f;
        }
        else if (Input.GetKey(teclas[1]))
        {
    
            //transform.Translate(0, -vel * Time.deltaTime, 0, Space.World);
            //pos += Vector3.down;
            rb.velocity = Vector2.down * vel * Time.deltaTime * 50f;
        }
        if (Input.GetKey(teclas[2]) )
        {
            //transform.Translate(vel * Time.deltaTime, 0, 0, Space.World);
            //pos += Vector3.right;
            rb.velocity = Vector2.right * vel * Time.deltaTime * 50f;
        }
        else if(Input.GetKey(teclas[3]) )
        {
            //transform.Translate(-vel * Time.deltaTime, 0, 0, Space.World);
            //pos += Vector3.left;
            rb.velocity = Vector2.left * vel * Time.deltaTime * 50f;
        }
        //transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * vel);
    }

    void OnTriggerEnter(Collider2D collision)
    {
        if(collision.gameObject.tag == "Muro")
        {
            Debug.Log("MURO");
            velocity = 0f;
        }
    }
}
