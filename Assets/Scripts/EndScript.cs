using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EndScript : MonoBehaviour
{

    private float EndBudget;
    private float budgetStart;
    private float FinalEndBudget;
    private float EndPoints;
    private float FinalEndPoints;
    private float discount = 1.25f;
    private float remainingPointsAdd;
   
    
    public Points points;
    public Budget budget;
    public Countdown time;

    public GameObject canvas;
    public Text pointsText;
    public Text pointsFinalText;
    public Text BudgetText;

    // Start is called before the first frame update

    private void Start()
    {
        canvas.SetActive(false);  
    }
    public void Endtrigger()
    {

        canvas.SetActive(true);
        EndBudget = budget.GetBudget();
        budgetStart = budget.BudgetStart();
        FinalEndBudget = (EndBudget * discount);
        EndPoints = points.GetPoints();
        FinalEndPoints = points.GetPoints() + FinalEndBudget + time.getTimeLeft();

    }

    // Update is called once per frame
    void Update()
    {
        if (canvas.activeInHierarchy == true)
        {
            pointsText.text = ("You earnt " + EndPoints.ToString() + " points");
            pointsFinalText.text = ("After bonuses your total points are " + FinalEndPoints.ToString());
            BudgetText.text = ("Your budget left was £" + FinalEndBudget.ToString());
            Time.timeScale = 0.0f;
        }
        

    }
}
