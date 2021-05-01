using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarMenu : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void CargaLevel(string pNombreNivel)
    {
        /*Encargado de reiniciar todo para cuando se vuelva a iniciar 
         * una partida (al ser "static" los textos no se reiniciaban)*/
        /*Score.score = 0;
        Score.enemigosDestruidos = 0;
        Score.esferaMagia = 0;
        Score.magia = 0;
        Score.magiaScore = 0;
        Score.baldosasReparadas = 0;*/
        //Score.contador = 0;
        SceneManager.LoadScene(pNombreNivel);
    }
}
