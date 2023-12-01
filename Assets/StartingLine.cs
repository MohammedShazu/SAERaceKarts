using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player's car
        if (other.CompareTag("Player"))
        {
            //you can add something to reset lap timers here
            Debug.Log("Race started!");
        }
    }
}