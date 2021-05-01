using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text timerText;
    float timeCount = 0;
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime * 2.5f;
        int apNumber = Mathf.FloorToInt(timeCount);
        timerText.text = apNumber.ToString();
    }
}
