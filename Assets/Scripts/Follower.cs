using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
using OVR;


public class Follower : MonoBehaviour
{

    public  PathCreator pathCreator;
    public float speed;
    float distTravelled;
    public GameObject canvas;

    void Update()
    {
        distTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distTravelled);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distTravelled);

        if(canvas.activeSelf)
        {
            speed = 0.1f;
        }

        if (!canvas.activeSelf)
        {
            if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) == true)
            {
                speed = 3.0f;
            }

            else
            {
                speed = 1.5f;
            }
            //if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) == false)
            //{
            //    speed = 1.5f;
            //}
        }
       
    }

}
