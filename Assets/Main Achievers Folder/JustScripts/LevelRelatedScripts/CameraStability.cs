using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStability : MonoBehaviour
{
    public GameObject Player; //declaring our car as the game object
    //camera for the car are declared as a float
    public float CarCamX;
    public float CarCamY;
    public float CarCamZ;

    // Update is called once per frame
    void Update()
    {
        //setting the x,y,z its values
        CarCamX = Player.transform.eulerAngles.x; //this is for us to access the subcomponenet of the car which is the rotation
        CarCamY = Player.transform.eulerAngles.y;
        CarCamZ = Player.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarCamX - CarCamX, CarCamY, CarCamZ - CarCamZ); //rotation is going opposite of where the car is going to keep the axis straight

    }
}