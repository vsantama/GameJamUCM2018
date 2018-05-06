using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SliderManager : MonoBehaviour
{
    public static SliderManager instance = null;

    public int CurrentLevel = 1;
    public float tiempo = 30f; //TIEMPO EN SEGUNDOS PARA MORIR
    public float tiempoRecarga = 10f;
    public Slider sliderBlanco;
    public Slider sliderNegro;
    public GameObject jugadorBlanco;
    public GameObject jugadorNegro;
    public PlayerManager managerBlanco;
    public PlayerManager managerNegro;


    public int getCurrentLevel() { return CurrentLevel; }
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        SliderManager.instance.jugadorBlanco = GameObject.Find("2DPlayer1(Clone)");
        if (SliderManager.instance.jugadorBlanco != null)
        {
         SliderManager.instance.managerBlanco = jugadorBlanco.GetComponent<PlayerManager>();
        }

        SliderManager.instance.jugadorNegro = GameObject.Find("2DPlayer2(Clone)");
           if(SliderManager.instance.jugadorNegro != null)
        {
            SliderManager.instance.managerNegro = jugadorNegro.GetComponent<PlayerManager>();
        }
        SliderManager.instance.sliderNegro.value = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(managerBlanco.tieneCorazon)
        {
            sliderNegro.value -= Time.deltaTime / tiempo; //Disminuye vida
            if(sliderBlanco.value != 0)
            {
            sliderBlanco.value -= Time.deltaTime / tiempoRecarga; //Aumenta vida
            }
        }
        else if(managerNegro.tieneCorazon)
        {
            sliderBlanco.value += Time.deltaTime / tiempo; //Disminuye vida 
            if(sliderNegro.value != 1)
            {
            sliderNegro.value += Time.deltaTime / tiempoRecarga; //Aumenta vida
            }
        }
        else if(!managerBlanco.tieneCorazon && !managerNegro.tieneCorazon)
        {
            sliderNegro.value -= Time.deltaTime / tiempo; //Disminuye vida
            sliderBlanco.value += Time.deltaTime / tiempo; //Disminuye vida 
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

    public void ResetearTiempo()
    {
       
        SliderManager.instance.jugadorBlanco = GameObject.Find("2DPlayer1(Clone)");
        SliderManager.instance.managerBlanco = jugadorBlanco.GetComponent<PlayerManager>();
        SliderManager.instance.jugadorNegro = GameObject.Find("2DPlayer2(Clone)");
        SliderManager.instance.managerNegro = jugadorNegro.GetComponent<PlayerManager>();
        SliderManager.instance.sliderNegro.value = 1;
    }
}