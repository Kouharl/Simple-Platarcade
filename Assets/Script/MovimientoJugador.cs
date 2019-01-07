using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour {
    public float FuerzaDeSalto = 10f;
    public bool SaltoDisponible = true;
    public Rigidbody2D RB2D;
    public int CantidadDeSaltos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space) && SaltoDisponible == true && CantidadDeSaltos < 1) //Saltar
        {
            RB2D.AddForce(Vector2.up * FuerzaDeSalto, ForceMode2D.Impulse);
            CantidadDeSaltos++;
            //SaltoDisponible = false;

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) && SaltoDisponible == true && CantidadDeSaltos < 2) //Segundo salto con menos fuerza
            {
                RB2D.AddForce(Vector2.up * (FuerzaDeSalto*0.7f), ForceMode2D.Impulse);
                CantidadDeSaltos=0;
                SaltoDisponible = false;

            }
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2 (1f*Time.deltaTime,0));
        }
        else {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector2(-1f*Time.deltaTime, 0));
            }
        }
       // if (Input.GetKey(KeyCode.W))
       // {
       //     transform.Translate(new Vector2(0, 0));
       // }
       //else
       // {
       //     if (Input.GetKeyDown(KeyCode.S))
       //     {
       //         transform.Translate(new Vector2(0, 0));
       //     }
       // }
    }
}
