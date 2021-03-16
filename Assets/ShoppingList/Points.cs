using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Points : MonoBehaviour
{
    // Start is called before the first frame update
    private float OverallPoints = 0;

    public Text PointsText;

    void Start()
    {
        
    }

    public void AddPoints(float points)
    {

        
        //added points
        OverallPoints = OverallPoints + points;
        Debug.Log("points");
    }

    public float GetPoints()
    {

        return OverallPoints;

    }

    public void TakePoints(float points)
    {

        OverallPoints = OverallPoints - points;

    }

    void Update()
    {

        PointsText.text = OverallPoints.ToString("");

    }
}
