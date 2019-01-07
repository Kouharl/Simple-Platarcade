using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventoTitulo : MonoBehaviour {
    public AudioSource audio2;
    public bool Iniciar=false;
    public bool salir=false;

    void Update()
    {
        if (Iniciar==true && !audio2.isPlaying) {
           SceneManager.LoadScene("Escena_1");
            Debug.Log("Cambio de escena!");
        }
    }
}
