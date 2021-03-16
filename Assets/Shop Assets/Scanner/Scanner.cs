using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;
using OVRTouchSample;
using VRTK;

public class Scanner : MonoBehaviour
{
    public Transform scanPoint;

    public float ScannerTrigger;
    private float ScannerGrab;

    Ray ray;
    RaycastHit hit;
    public LineRenderer rayCastLine;
    public GameObject objectHit;
    public AudioSource scanNoise;
    public GameObject raycastEnd;
    public ShoppingList shopList; //adding shopping list for testing, requires gameobject with shopping list on to be dragged in
    // Start is called before the first frame update
    void Start()
    {
        scanNoise = GetComponent<AudioSource>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        rayCastLine.SetPosition(0, scanPoint.position);
        rayCastLine.SetPosition(1, raycastEnd.transform.position);
        Scanhit();
    }

    public void Scanhit()
    {
        //Debug.DrawRay(scanPoint.position, scanPoint.forward, Color.red);
        //Debug.DrawLine(scanPoint.position, scanPoint.transform.TransformDirection(Vector3.up) * 1000.0f, Color.yellow);
        //if (ScannerTrigger >= 0.7f)

        //Debug.DrawLine(scanPoint.position, scanPoint.transform.TransformDirection(Vector3.up) * 50.0f, Color.blue);

           
            if (Physics.Raycast(scanPoint.position, scanPoint.transform.TransformDirection(Vector3.up), out hit, 200.0f))
            //if(Physics.CapsuleCast(scanPoint.position, raycastEnd.transform.position, 90.0f, scanPoint.transform.TransformDirection(Vector3.up)))
            {
                objectHit = hit.transform.parent.gameObject;
                if (hit.transform.gameObject.tag == "Barcode")
                {
                    
                    //Debug.DrawLine(scanPoint.position, scanPoint.transform.TransformDirection(Vector3.up) * 1000.0f, Color.blue);
                    scanNoise.Play(); //add back in it bugged for me
                    objectHit.tag = (objectHit.name.ToString());
                    //shopList.CheckItem(objectHit.name, true); //how we send the object name data and relay it to check item
                    //print(objectHit.name); //troubleshooting

                }
                else
                {

                //do nothing

                }

            }

        

    }
}

