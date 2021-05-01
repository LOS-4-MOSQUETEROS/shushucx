using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        //StartCoroutine(Corrutina());
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.position += (Vector3.right * h + Vector3.up * v) * Time.deltaTime * speed;
    }
    /*IEnumerator Corrutina()
    {
        yield return new WaitForSeconds(7);
        speed *= 1.1f;
        StartCoroutine(Corrutina());
    }*/
}
