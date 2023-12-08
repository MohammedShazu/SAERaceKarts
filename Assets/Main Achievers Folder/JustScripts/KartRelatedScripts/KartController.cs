using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
     private float _forwardAmount;
    private float _turnAmount;
    private float _currentSpeed;
   [SerializeField] private float fowardSpeed;
   [SerializeField] private float turnSpeed;
   [SerializeField] private GameObject startTimer;
    public bool countdownFinished = false;

    //creating a private rigidbody for reference
    // Start is called before the first frame update
    void Start()
    {
        rb.transform.parent = null;
        //it's made a parent so the placeholder object doesn't follow the kart
    }

    // Update is called once per frame
    void Update()
    {
        if(countdownFinished)
        {

            transform.position = rb.transform.position;
            //the kart is essentially following the object
            _forwardAmount = Input.GetAxis("Vertical");
            _turnAmount = Input.GetAxis("Horizontal");



            if (_forwardAmount != 0)
            {
                DriveForward();
            }

            else if (_forwardAmount < 0)
            {
                Reverse();
            }
            if (_forwardAmount == 0)
            {
                Idle();
            }

            TurnHandler();
        }
    }

   

    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * _currentSpeed, ForceMode.Acceleration);
    }
    private void DriveForward()
    {
        _currentSpeed = _forwardAmount *= fowardSpeed;
    } 
    private void Reverse()
    {
        _currentSpeed = _forwardAmount *= fowardSpeed;
    } 
     private void Idle()
    {
        _currentSpeed = 0;
    }
    //This makes the car moving when you press play
    private void TurnHandler()
    {
        float newRotation = _turnAmount * turnSpeed * Time.deltaTime;
        transform.Rotate(0, newRotation, 0, Space.World);
    }
    //steering controls

    public void CountdownFinished()
    {
        countdownFinished = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "StartLine")
        {
            Debug.Log("You Have Started");
            startTimer.GetComponent<Timer>().timeIsRunning = true;
        }
        if (collision.collider.tag == "FinishLine")
        {
            Debug.Log("You have finished");
        }
    }
}
