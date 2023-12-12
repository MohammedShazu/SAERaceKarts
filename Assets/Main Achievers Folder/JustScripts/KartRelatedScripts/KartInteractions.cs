using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartInteractions : MonoBehaviour
{
    public GameObject kartPlayer;

    public bool passingTurn1;
    public bool passingTurn2;

    // Start is called before the first frame update
    void Start()
    {
        passingTurn1 = false;
        passingTurn2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Turn1"))
        {
            passingTurn1 = true;
        }
        if (other.CompareTag("Turn2"))
        {
           passingTurn2 = true;
        }
    }
}
