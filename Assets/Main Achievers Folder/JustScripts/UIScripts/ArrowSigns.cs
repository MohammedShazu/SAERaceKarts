using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSigns : MonoBehaviour
{
    public GameObject turnLeft;
    public GameObject shortTurnLeft;
    public float signTimer;
    public KartInteractions kartInteractions;

    // Start is called before the first frame update
    void Start()
    {
        signTimer = 0f;
        kartInteractions = FindObjectOfType<KartInteractions>();
    }

    // Update is called once per frame
    void Update()
    {
        if(kartInteractions.passingTurn1 == true)
        {
            if(signTimer <= 1.5)
            {
                turnLeft.SetActive(true); // displays sign
                signTimer += Time.deltaTime;
            }
            if(signTimer >= 1.5)
            {
                turnLeft.SetActive(false); // stops display
                signTimer = 0;
                kartInteractions.passingTurn1 = false;
            }
        }


        if(kartInteractions.passingTurn2 == true)
        {
           if(signTimer <= 2.0)
            {
                shortTurnLeft.SetActive(true); // displays sign
                signTimer += Time.deltaTime;
            }
            if(signTimer >= 2.0)
            {
                shortTurnLeft.SetActive(false); // stops display
                signTimer = 0;
                kartInteractions.passingTurn2 = false;
            }
        }
    }
}
