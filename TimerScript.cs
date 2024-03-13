using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TimerScript : MonoBehaviour
{
    public float timeLeft = 60f;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        }
        else
        {
            PlayerScript.dead = true;
        }
        string seconds = Math.Round((timeLeft % 60)).ToString();
        if(seconds.Length < 2)
        {
            seconds = "0" + seconds;
        }
        string minutes = Math.Floor((timeLeft / 60)).ToString();
        if(minutes == "0")
        {
            timerText.text = seconds;
        }
        else
        {
            timerText.text = minutes + ":" + seconds;
        }
    }
}
