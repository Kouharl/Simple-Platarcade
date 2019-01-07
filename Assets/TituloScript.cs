using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TituloScript : MonoBehaviour {
    public AudioSource Sonido;
   // public GameObject evento;
    public bool Iniciar2S = false;
    public bool Salir2S   = false;
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
        Debug.Log("Iniciando");
        Sonido.Play();
        Iniciar2S = true;


     


    }

public void Salir ()
    {
        Debug.Log("Saliendo");
        Debug.Break();//para poner en pausa. Simular una salida.
        
    }
}
