using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TituloScript : MonoBehaviour {
    public AudioSource Sonido;
   // public GameObject evento;
    public bool Iniciar2S = false;
    public bool Salir2S   = false;
    public Animator Transicion;
    public Animator TransicionBotonInicio;
    public Animator TransicionBotonSalir;
    // public float condic;

    void Start()
    { }
    void Update() {

        if (Iniciar2S==true && !Sonido.isPlaying)
        {
            SceneManager.LoadScene("Escena_1");
            Debug.Log("Cambio de escena!");
        }
    }

    public void Iniciar ()
    {
        if (Iniciar2S==false) { 
        Debug.Log("Iniciando");
        Sonido.Play();
        Iniciar2S = true;
        Transicion.SetBool("Iniciando",true); // Inicio condicion para activar la animacion de transicion de escena
        TransicionBotonInicio.SetBool("Iniciando", true);
        TransicionBotonSalir.SetBool("Iniciando", true);
        }


    }

public void Salir ()
    {
        if (Salir2S==false && Iniciar2S == false) { 
        Debug.Log("Saliendo");
        Debug.Break();//para poner en pausa. Simular una salida.
    }
}
}
