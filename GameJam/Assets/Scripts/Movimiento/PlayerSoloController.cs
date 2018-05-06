using UnityEngine;

public class PlayerSoloController : MonoBehaviour
{

    public float velocity = 20f;
    public KeyCode[] teclas1 = { KeyCode.W, KeyCode.S, KeyCode.D, KeyCode.A };
    public KeyCode[] teclas2 = { KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.RightArrow, KeyCode.LeftArrow };
    public Rigidbody2D rb;

    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    
    void FixedUpdate()
    {
        Move(velocity);
    }

    void Move(float vel)
    {
        // anims
        anim.SetBool("AndarArriba", false);
        anim.SetBool("AndarAbajo", false);
        anim.SetBool("AndarDerecha", false);
        anim.SetBool("AndarIzqu", false);
        anim.SetBool("Idle", true);

        rb.velocity = new Vector3(0, 0, 0);
        if ((Input.GetKey(teclas1[0]) && Input.GetKey(teclas2[0])))
        {
            anim.SetBool("AndarArriba", true);
            anim.SetBool("Idle", false);
            //.Translate(0, vel * Time.deltaTime, 0, Space.World);
            rb.velocity = Vector2.up * vel * Time.deltaTime * 50f;
        }
        if ((Input.GetKey(teclas1[1]) && Input.GetKey(teclas2[1])))
        {
            anim.SetBool("AndarAbajo", true);
            anim.SetBool("Idle", false);
            //transform.Translate(0, -vel * Time.deltaTime, 0, Space.World);
            rb.velocity = Vector2.down * vel * Time.deltaTime * 50f;
        }
        if ((Input.GetKey(teclas1[2]) && Input.GetKey(teclas2[2])))
        {
            anim.SetBool("AndarDerecha", true);
            anim.SetBool("Idle", false);
            //transform.Translate(vel * Time.deltaTime, 0, 0, Space.World);
            rb.velocity = Vector2.right * vel * Time.deltaTime * 50f;
        }
        if ((Input.GetKey(teclas1[3]) && Input.GetKey(teclas2[3])))
        {
            anim.SetBool("AndarIzqu", true);
            anim.SetBool("Idle", false);
            //transform.Translate(-vel * Time.deltaTime, 0, 0, Space.World);
            rb.velocity = Vector2.left * vel * Time.deltaTime * 50f;
        }

        //transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * vel);
    }
}
