using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public GameEnding gameEnding;

    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        InvokeRepeating("TimeLog", 0f, 1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        OutOfTime();

    }

    void TimeLog()
    {
        time = time + 1;
        timerText.text = "Timer: " + time;
        Debug.Log("time: " + time);
    }
    
    void OutOfTime()
    {
        if(time >= 60.00)
        {
            gameEnding.CaughtPlayer();
            time = 0;
            timerText.color = new Color(255, 255, 255, 0);
        }
    }

}
