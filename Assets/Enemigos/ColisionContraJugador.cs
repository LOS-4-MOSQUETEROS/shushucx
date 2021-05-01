using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionContraJugador : MonoBehaviour
{
    //public GameObject jugadorVivo;
    //public GameObject jugadorMuerto;      
    //public AudioSource audio;
    //MeshRenderer mr;

    void Start()
    {
       //mr = GetComponent<MeshRenderer>();
       // audio = GetComponent<AudioSource>();
    }
    IEnumerator Corrutina()
    {
        print("entra a corrutina");
        //jugadorVivo.SetActive(false);       
        //jugadorMuerto.SetActive(true);
        print("desactiva y activa");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameOver");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //mr.material.color = Color.red;
            //audio.Play();
            StartCoroutine(Corrutina());
        }
    }

}
