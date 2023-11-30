using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
     private float _forwardAmount;
    private float _currentSpeed;
   [SerializeField] private float fowardSpeed;

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
        transform.position = rb.transform.position;
        //the kart is essentially following the object
        _forwardAmount  = Input.GetAxis("Vertical");
        if(_forwardAmount != 0)
        {
            DriveForward();
        }
        
        else if(_forwardAmount < 0)
        {
            Reverse();
        }
        if(_forwardAmount == 0)
        {
            Idle();
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
        throw new NotImplementedException();
    }

}
