/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
   
    internal enum updateMethod
    {
        fixedUpdate,
        update,
        lateUpdate,
    }
    [SerializeField] private updateMethod updateDemo;

    public GameObject cameraLookAtObject; 
    private controller controllerReference;
    public float [Range(0,20)] smoothTime - 5;

    private void Start()
    {
        controllerReference = GameObject.FindGameObjectWithTag("Player").GetComponent<controller>();
        cameraLookAtObject = GameObject.FindGameObjectWithTag("Player").transform.Find("camera LookAt").gameObject;
    }

    private void fixedUpdate()
    {
        if (updateDemo == updateMethod.fixedUpdate)
            cameraBehaviour();
    }

    private void update()
    {
        if (updateDemo == updateMethod.update)
            cameraBehaviour();
    }

    private void lateUpdate()
    {
        if (updateDemo == updateMethod.update)
            cameraBehaviour();
    }

    private void cameraBehaviour()
    {
        Vector3 Velocity = 0;
        transform.position = vector3.SmoothDamp(transform.position, cameraLookAtObject.transform.position, ref velocity, smoothTime * time.deltaTime);
    }
}
*/