using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player's car
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has reached the finish line!");
            // This is where you can add a finish line for example displaying a victory screen.
        }
    }
}
