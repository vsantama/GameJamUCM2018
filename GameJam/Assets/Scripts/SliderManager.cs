using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SliderManager : MonoBehaviour
{
    static SliderManager instance;

    public int CurrentLevel;
    public float tiempo = 30f; //TIEMPO EN SEGUNDOS PARA MORIR
    public float tiempoRecarga = 10f;
    public Slider sliderBlanco;
    public Slider sliderNegro;
    public GameObject jugadorBlanco;
    public GameObject jugadorNegro;
    public PlayerManager managerBlanco;
    public PlayerManager managerNegro;

    private void Start()
    {
        instance = this;
    }
    // Use this for initialization
    void Awake()
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
        if(managerBlanco.tieneCorazon && !managerNegro.tieneCorazon)
        {
            sliderNegro.value -= Time.deltaTime / tiempo; //Disminuye vida
            if(sliderBlanco.value != 0)
            {
            sliderBlanco.value -= Time.deltaTime / tiempoRecarga; //Aumenta vida
            }
        }
        else if(managerNegro.tieneCorazon && !managerBlanco.tieneCorazon)
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
           Invoke("ReiniciarNivel", 2f);
        }
    }
        void ReiniciarNivel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        void PasarSiguienteNivel()
    {
        string nextScene = "Nivel" + (CurrentLevel + 1).ToString();
        CurrentLevel++;
        SceneManager.LoadScene(nextScene);
    }
}