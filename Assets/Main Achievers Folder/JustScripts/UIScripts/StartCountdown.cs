using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCountdown : MonoBehaviour
{
    public float countdownTimer;
    public GameObject countdown3;
    public GameObject countdown2;
    public GameObject countdown1;
    public GameObject countdownGo;


    // Start is called before the first frame update
    void Start()
    {
        countdownTimer -= Time.deltaTime;

        if(countdownTimer <= -1)
        {
            countdownTimer = 5; // Starts going down
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if(countdownTimer <= 3)
        {
            countdown3.SetActive(true);
        }

        if(countdownTimer <= 2)
        {
            countdown2.SetActive(true);
            countdown3.SetActive(false);
        }

        if(countdownTimer <= 1)
        {
            countdown1.SetActive(true);
            countdown2.SetActive(false);
        }

        if(countdownTimer <= 0)
        {
            countdownGo.SetActive(true);
            countdown1.SetActive(false);
        }

        if(countdownTimer <= -1)
        {
            countdownGo.SetActive(false);
        }
    }
}
