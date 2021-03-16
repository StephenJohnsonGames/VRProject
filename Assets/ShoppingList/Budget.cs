using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Budget : MonoBehaviour
{
    // Start is called before the first frame update
    private float OverallBudget = 0;
    public float budgetStart;
    public Text BudgetText;
    void Start()
    {

    }

    public void SetupBudget(float budget)
    {

        //added points
        OverallBudget = budget;
        budgetStart = budget;
        //Debug.Log(OverallBudget);

    }

    public void TakeBudget(float cost)
    {

        OverallBudget = OverallBudget - cost;

    }

    public float GetBudget()
    {

        return OverallBudget;

    }

    public float BudgetStart()
    {

        return budgetStart;

    }

    void Update()
    {

        BudgetText.text = OverallBudget.ToString("");

    }

}
