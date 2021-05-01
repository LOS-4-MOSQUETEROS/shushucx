using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovMar : MonoBehaviour
{
    public float velInicio; //Mínimo aumento de velocidad
    public float velMax; //Máximo aumento de velocidad del mar
    public float SegAEsperar; //tiempo a esperar entre cada vuelta
    public float aumentarVel; //velocidad que aumentamos a cada vuelta
    void Start()
    {
        StartCoroutine(Corrutina());
    }

    void Update()
    {
        transform.position += Vector3.down * velInicio * Time.deltaTime;
        if(transform.position.y <= -11f)
        {
            transform.position = new Vector3(0, 11f, 0);
        }
    }
    IEnumerator Corrutina()
    {
        yield return new WaitForSeconds(SegAEsperar);
        velInicio += aumentarVel;
        print(velInicio);
        if (velInicio >= velMax)
        {
            //print ("paramos");
            StopCoroutine(Corrutina());
        }
        else 
        {
            //print("seguimos");
            StartCoroutine(Corrutina());
        }
    }
}
        
