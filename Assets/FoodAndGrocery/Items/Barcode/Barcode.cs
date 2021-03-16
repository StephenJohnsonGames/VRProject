using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barcode : MonoBehaviour
{
    public GameObject Scanner;
    //RaycastHit itemHit;

    public GameObject parentObject;
    public Collider collider;
    public bool scannedObject;
    public Collider parentCollider;
    // Start is called before the first frame update
    void Start()
    {
        Scanner = GameObject.Find("ScannerPoint");
        parentObject = this.transform.parent.gameObject;
        collider = this.GetComponent<Collider>();
        parentCollider = parentObject.GetComponent<Collider>();
        //itemHit = Scanner.GetComponent<RaycastHit>();
        Physics.IgnoreCollision(parentCollider, collider);
    }

    // Update is called once per frame
    void Update()
    {

        //don't do it, chuggs framerate

        //if (itemHit.transform.gameObject.tag == "Barcode")
     
           // Debug.Log("hit");
            //parentObject.tag = (parentObject.name.ToString());

        

    }
}
