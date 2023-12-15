using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
    { 
    public int currentLap;
    private void Start()
    {
    currentLap = 1;
    }
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player's car
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has reached the finish line!");
            currentLap ++;
            // This is where you can add a finish line for example displaying a victory screen.
        }
        if (currentLap == 3)
        {
            Debug.Log("Player has finished the race!!!");
            SceneManager.LoadScene("FinishScene");
        }
    }
}
