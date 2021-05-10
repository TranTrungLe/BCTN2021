using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimer : MonoBehaviour
{
    public Text textTimer;

    private float timer = 0.0f;
    private static bool isTimer = false;
    public static bool x ;
    public static float y;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        DisplayTime();
    }

    void DisplayTime()
    {
        if(x == true)
        {
            int minutes = Mathf.FloorToInt(timer / 60.0f);
            int seconds = Mathf.FloorToInt(timer - minutes * 60);
            textTimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            
        }
        //textTimer.text = y.ToString();

    }

    public void StartTimer()
    {
        isTimer = true;
        x = true;
    }

    public void StopTimer()
    {
        isTimer = false;
    }

    public void ResetTimer()
    {
        timer = 0.0f;
        x = true;
    }
}
