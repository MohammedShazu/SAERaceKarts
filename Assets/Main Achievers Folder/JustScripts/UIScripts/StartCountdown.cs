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

    public KartController kartController;


    // Start is called before the first frame update
    void Start()
    {
        countdownTimer = 5;
        kartController = FindObjectOfType<KartController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(countdownTimer >= -0.25f)
        {
            countdownTimer -= Time.deltaTime; // Timer goes down
        }

        if(countdownTimer <= 3.25f)
        {
            countdown3.SetActive(true);
        }

        if(countdownTimer <= 2.25f)
        {
            countdown2.SetActive(true);
            countdown3.SetActive(false);
        }

        if(countdownTimer <= 1.25f)
        {
            countdown1.SetActive(true);
            countdown2.SetActive(false);
        }

        if(countdownTimer <= 0.25f)
        {
            countdownGo.SetActive(true);
            countdown1.SetActive(false);
            kartController.countdownFinished = true;
        }

        if(countdownTimer <= -0.25f)
        {
            countdownGo.SetActive(false);
        }

       
    }
}
