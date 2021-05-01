using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionContraEnemigo : MonoBehaviour
{
    public GameObject jugadorVivo;
    public GameObject jugadorMuerto;      
    public AudioSource audio1;
    Movimiento moverjugador;
    //MeshRenderer mr;

    void Start()
    {
        moverjugador = GetComponent<Movimiento>();
        //mr = GetComponent<MeshRenderer>();
        audio1 = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemigo")
        {
            moverjugador.GetComponent<Movimiento>().enabled = false;
            jugadorVivo.SetActive(false);
            jugadorMuerto.SetActive(true);
            //mr.material.color = Color.red;
            audio1.Play();
        }
    }
}
