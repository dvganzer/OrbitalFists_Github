using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMovement : MonoBehaviour
{
    public float Clockwise_roatationSpeed;
    public float Counterclockwise_roatationSpeed;
 
    public GameObject rightHand;
    public GameObject leftHand;
    public GameObject Body;

   

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rightHand.transform.RotateAround(Body.transform.position, Vector3.forward, Counterclockwise_roatationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            leftHand.transform.RotateAround(Body.transform.position, Vector3.forward, Counterclockwise_roatationSpeed * Time.deltaTime);
        }
         


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rightHand.transform.position -= transform.right * 1;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            leftHand.transform.position += transform.right * 1;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            rightHand.transform.position += transform.right * 1;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            leftHand.transform.position -= transform.right * 1;
        }

    }
}
