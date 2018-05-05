using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float velocity = 15f;
    public KeyCode[] teclas = new KeyCode[4];
    public Rigidbody2D rb;

    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void FixedUpdate () {
        Move(velocity);
    }

    void Move(float vel)
    {
        // anims
        anim.SetBool("AndarArriba", false);
        anim.SetBool("AndarAbajo", false);
        anim.SetBool("AndarDerecha", false);
        anim.SetBool("AndarIzqu", false);

        rb.velocity = new Vector3(0, 0, 0);

        if (Input.GetKey(teclas[0]))
        {
            anim.SetBool("AndarArriba", true);
            rb.velocity = Vector2.up * vel * Time.deltaTime * 50f;
        }
        else if (Input.GetKey(teclas[1]))
        {
            anim.SetBool("AndarAbajo", true);
            rb.velocity = Vector2.down * vel * Time.deltaTime * 50f;
        }
        if (Input.GetKey(teclas[2]))
        {
            anim.SetBool("AndarDerecha", true);
            rb.velocity = Vector2.right * vel * Time.deltaTime * 50f;
        }
        else if (Input.GetKey(teclas[3]))
        {
            anim.SetBool("AndarIzqu", true);
            rb.velocity = Vector2.left * vel * Time.deltaTime * 50f;
        }
    }
}
