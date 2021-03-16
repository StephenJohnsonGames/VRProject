using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrolleyChecker : MonoBehaviour
{

    public ShoppingList shop;

    public void OnTriggerEnter(Collider other)
    {

        string objectName = other.name;
        string scannedStatus = other.tag;
        bool scannedBool = false;

        if (scannedStatus == objectName)
        {

            scannedBool = true;
            shop.CheckItem(objectName, scannedBool, true);

        }
        else
        {

            shop.CheckItem(objectName, scannedBool, true);

        }
        

        



    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
