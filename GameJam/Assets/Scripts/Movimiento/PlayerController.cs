using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float velocity = 15f;
    public KeyCode[] teclas = new KeyCode[4];
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
            rb.velocity = Vector2.up * vel * Time.deltaTime * 50f;
        }
        else if (Input.GetKey(teclas[1]))
        {
            rb.velocity = Vector2.down * vel * Time.deltaTime * 50f;
        }
        if (Input.GetKey(teclas[2]) )
        {
            rb.velocity = Vector2.right * vel * Time.deltaTime * 50f;
        }
        else if(Input.GetKey(teclas[3]) )
        {
            rb.velocity = Vector2.left * vel * Time.deltaTime * 50f;
        }

    }
}
