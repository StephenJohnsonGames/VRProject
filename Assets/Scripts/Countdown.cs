using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using PathCreation;

public class Countdown : MonoBehaviour
{
    public float currentTime = 0f;
    float startTime = 161;
    public GameObject Loading;
    public GameObject Trolley;
    float TimeLeft;

    public EndScript gameOver;

    [SerializeField] Text countdown;

    void Start()
    {
        currentTime = startTime;
        
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        countdown.text = currentTime.ToString("000 Secs");

        if (currentTime <= 0)
        {
            currentTime = 0;
            EndGameToTime();
        }

        if (currentTime < 180)
        {
            Loading.SetActive(false);
            
        }
    }

    void EndGameToTime()
    {


        gameOver.Endtrigger();
        //Time.timeScale = 0.0f;
        
            //pauses the game at the end of the timer

    }

    public float getTimeLeft()
    {

        return TimeLeft;

    }

}