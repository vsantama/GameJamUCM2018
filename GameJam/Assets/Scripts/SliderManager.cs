using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SliderManager : MonoBehaviour
{
    
    public float tiempo = 30f; //TIEMPO EN SEGUNDOS PARA MORIR
    public float tiempoRecarga = 10f;
    public Slider sliderBlanco;
    public Slider sliderNegro;
    public GameObject jugadorBlanco;
    public GameObject jugadorNegro;
    public PlayerManager managerBlanco;
    public PlayerManager managerNegro;
    // Use this for initialization
    void Start()
    {

        //Hacerlo con mensajes
        jugadorBlanco = GameObject.Find("2DPlayer1");
        managerBlanco = jugadorBlanco.GetComponent<PlayerManager>();
        jugadorNegro = GameObject.Find("2DPlayer2");
        managerNegro = jugadorNegro.GetComponent<PlayerManager>();
        sliderNegro.value = 1;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(managerBlanco.tieneCorazon == true && managerNegro.tieneCorazon == false)
        {
            sliderNegro.value -= Time.deltaTime / tiempo; //Disminuye vida
            if(sliderBlanco.value != 0)
            {
            sliderBlanco.value -= Time.deltaTime / tiempoRecarga; //Aumenta vida
            }
        }
        else if(managerNegro.tieneCorazon == true && managerBlanco.tieneCorazon == false)
        {
            sliderBlanco.value += Time.deltaTime / tiempo; //Disminuye vida 
            if(sliderNegro.value != 1)
            {
            sliderNegro.value += Time.deltaTime / tiempoRecarga; //Aumenta vida
            }
        }
        if(sliderNegro.value == 0 || sliderBlanco.value == 1)
        {
            //REINICIAR LEVEL
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}