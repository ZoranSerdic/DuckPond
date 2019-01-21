using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI text;

    public float realTime = 0.0f;
    public float Time;

    public static bool GameStarted = false;

    void Update()
    {
        if (GameStarted == true)
        {
            realTime += UnityEngine.Time.deltaTime;
            Time = Mathf.Floor(realTime);

            text.text = "" + Time;
        }
    }
}
