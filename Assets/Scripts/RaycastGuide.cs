using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGuide : MonoBehaviour
{
    public LineRenderer rayCastLine;
    public GameObject rayCastEnd;
    public GameObject hand;

    // Start is called before the first frame update
    void Start()
    {
        rayCastLine = this.GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        rayCastLine.SetPosition(0, this.transform.position);
        rayCastLine.SetPosition(1, rayCastEnd.transform.position);
    }
}
