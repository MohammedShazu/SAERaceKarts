using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartInteractions : MonoBehaviour
{
    public GameObject kartPlayer;

    public bool passingTurn1;
    public bool passingTurn2;
    public bool passingTurn3;
    public bool passingTurn4;
    public bool passingTurn5;

    // Start is called before the first frame update
    void Start()
    {
        passingTurn1 = false;
        passingTurn2 = false;
        passingTurn3 = false;
        passingTurn4 = false;
        passingTurn5 = false;
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
             Debug.Log("TurnApproaching");
        }
        if (other.CompareTag("Turn2"))
        {
           passingTurn2 = true;
        }
        if (other.CompareTag("Turn3"))
        {
            passingTurn3 = true;
        }
        if (other.CompareTag("Turn4"))
        {
           passingTurn4 = true;
        }
        if (other.CompareTag("Turn5"))
        {
            passingTurn5 = true;
        }
    }
}
