using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovRoca1 : MonoBehaviour
{
    public float speed = 1f;
    float contador = 0;

    void Start()
    {
        StartCoroutine(Corrutina());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
    IEnumerator Corrutina()
    {
        yield return new WaitForSeconds(7);
        speed *= 1.1f;
        StartCoroutine(Corrutina());
    }
}
