using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDeEnemigos : MonoBehaviour
{
    public GameObject roc1, roc2, roc3, roc4, roc5, roc6, roc7, roc8, roc9, roc10;
    public GameObject spawn;
    public float speed = 1f;
    public int azar;
    public int rocaAlAzar;
    float azarroc1, azarroc2, azarroc3, azarroc4, azarroc5, azarroc6, azarroc7, azarroc8, azarroc9, azarroc10;
    void Start()
    {
        StartCoroutine(Corrutina());
        azarroc1 = 99;
        azarroc2 = 199;
        azarroc3 = 299;
        azarroc4 = 399;
        azarroc5 = 499;
        azarroc6 = 599;
        azarroc7 = 699;
        azarroc8 = 799;
        azarroc9 = 899;
        azarroc10 = 999;
    }

    void Update()
    {
    }
    IEnumerator Corrutina()
    {
        rocaAlAzar = Random.Range(0, 999);
        azar = Random.Range (2, 11);
        print(rocaAlAzar);
        yield return new WaitForSeconds(azar);
        if(rocaAlAzar <= azarroc1)
        {
            Instantiate(roc1, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        
        }
        else if (rocaAlAzar <= azarroc2)
        {
            //azar = Random.Range(2, 11);
            //yield return new WaitForSeconds(azar);
            Instantiate(roc2, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        }
        else if (rocaAlAzar <= azarroc3)
        {
            //azar = Random.Range(2, 11);
            //yield return new WaitForSeconds(azar);
            Instantiate(roc3, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        }
        else if (rocaAlAzar <= azarroc4)
        {
            //azar = Random.Range(2, 11);
            //yield return new WaitForSeconds(azar);
            Instantiate(roc4, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        }
        else if (rocaAlAzar <= azarroc5)
        {
            //azar = Random.Range(2, 11);
            //yield return new WaitForSeconds(azar);
            Instantiate(roc5, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        }
        else if (rocaAlAzar <= azarroc6)
        {
            //azar = Random.Range(2, 11);
            //yield return new WaitForSeconds(azar);
            Instantiate(roc6, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        }
        else if (rocaAlAzar <= azarroc7)
        {
            //azar = Random.Range(2, 11);
            //yield return new WaitForSeconds(azar);
            Instantiate(roc7, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        }
        else if (rocaAlAzar <= azarroc8)
        {
            //azar = Random.Range(2, 11);
            //yield return new WaitForSeconds(azar);
            Instantiate(roc8, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        }
        else if (rocaAlAzar <= azarroc9)
        {
            //azar = Random.Range(2, 11);
            //yield return new WaitForSeconds(azar);
            Instantiate(roc9, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        }
        else if (rocaAlAzar <= azarroc10)
        {
            //azar = Random.Range(2, 11);
            //yield return new WaitForSeconds(azar);
            Instantiate(roc10, spawn.transform.position, Quaternion.identity);
            StartCoroutine(Corrutina());
        }
    }
}

