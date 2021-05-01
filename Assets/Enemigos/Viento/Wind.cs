using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    internal float force;
    internal Vector3 direction;
    public Transform player;
    public GameObject[] windObjects;
    public IEnumerator WindRoutine(float time)
    {
        float timer = 0;
        while (timer < time)
        {
            timer += Time.deltaTime;
            transform.position += direction * force * Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }
        yield return null;
    }

    public void ChangeWind(Vector3 _dir, float _force, float time)
    {
        StopAllCoroutines();
        force = _force;
        direction = _dir;
        StartCoroutine(WindRoutine(time));
    }

    public void StopWind()
    {
        StopAllCoroutines();
    }
}
