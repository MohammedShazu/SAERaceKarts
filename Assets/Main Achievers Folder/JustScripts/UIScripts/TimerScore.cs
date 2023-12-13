using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScore : MonoBehaviour
{
    public bool finalTime;
    public TMP_Text finalScore;
    public Timer timer;
    public Finish finish;

    // Start is called before the first frame update
    void Start()
    {
        finalTime = false;
        timer = FindObjectOfType<Timer>();
        finish = FindObjectOfType<Finish>();
    }

    // Update is called once per frame
    void Update()
    {
        if(finish.currentLap == 3)
        {
            finalTime = true;
        }

        if(finalTime == true)
        {
            timer.timeIsRunning = false;
            
            if (timer.timeRemaining >= 0)
            {
                DisplayFinalTime(timer.timeRemaining);
                
            }
                
        }
    }

    void DisplayFinalTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        finalScore.text = string.Format("Score: " + "{0:00} : {1:00}", minutes, seconds);
    }
}
