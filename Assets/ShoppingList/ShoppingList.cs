using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShoppingList : MonoBehaviour
{
    
    public const string path = "items";

    //private int[] ItemID;
    private int Item1ID;
    private int Item2ID;
    private int Item3ID;
    private int Item4ID;
    private int Item5ID;
    private int Item6ID;
    private int Item7ID;
    private int Item8ID;
    private int Item9ID;
    private int Item10ID;

    //private string [] itemNames;
    private string item1Name;
    private string item2Name;
    private string item3Name;
    private string item4Name;
    private string item5Name;
    private string item6Name;
    private string item7Name;
    private string item8Name;
    private string item9Name;
    private string item10Name;

    //private string[] objectNames;
    private string item1ObName;
    private string item2ObName;
    private string item3ObName;
    private string item4ObName;
    private string item5ObName;
    private string item6ObName;
    private string item7ObName;
    private string item8ObName;
    private string item9ObName;
    private string item10ObName;

    //private float[] itemCosts;
    private float item1Cost;
    private float item2Cost;
    private float item3Cost;
    private float item4Cost;
    private float item5Cost;
    private float item6Cost;
    private float item7Cost;
    private float item8Cost;
    private float item9Cost;
    private float item10Cost;

    //private float[] itemPoints;
    private float item1Point;
    private float item2Point;
    private float item3Point;
    private float item4Point;
    private float item5Point;
    private float item6Point;
    private float item7Point;
    private float item8Point;
    private float item9Point;
    private float item10Point;


    public Points other;
    public Budget budget;

    public Text Item1UIName;
    public Text Item2UIName;
    public Text Item3UIName;
    public Text Item4UIName;
    public Text Item5UIName;
    public Text Item6UIName;
    public Text Item7UIName;
    public Text Item8UIName;
    public Text Item9UIName;
    public Text Item10UIName;

    public Text Item1Status;
    public Text Item2Status;
    public Text Item3Status;
    public Text Item4Status;
    public Text Item5Status;
    public Text Item6Status;
    public Text Item7Status;
    public Text Item8Status;
    public Text Item9Status;
    public Text Item10Status;

    // Start is called before the first frame update
    void Start()
    {

        ItemContainer ic = ItemContainer.Load(path);
        //random generation of ID's
        Item1ID = Random.Range(1, 4);
        Item2ID = Random.Range(5, 9);
        Item3ID = Random.Range(10, 14);
        Item4ID = Random.Range(15, 19);
        Item5ID = Random.Range(20, 24);
        Item6ID = Random.Range(25, 29);
        Item7ID = Random.Range(30, 34);
        Item8ID = Random.Range(35, 39);
        Item9ID = Random.Range(40, 43);
        Item10ID = Random.Range(44, 46);
        //print("set id's");

        //Item1ID = 21;
        //Item2ID = 7;
        //Item3ID = 15;
        //Item4ID = 19;
        //Item5ID = 25;
        other.AddPoints(10);
        budget.SetupBudget(40);
        
        foreach (Item item in ic.items)
        {
            //setting up Shopping list from database
                        
            if (item.itemID == Item1ID)
            {
                print(Item1ID);
                item1Name = item.itemName;
                item1ObName = item.ObjectName;
                item1Cost = item.itemCost;
                item1Point = item.itemPoints;
                print(item1Name);

            } //set varibles
            if (item.itemID == Item2ID)
            {

                print(Item2ID);
                item2Name = item.itemName;
                item2ObName = item.ObjectName;
                item2Cost = item.itemCost;
                item2Point = item.itemPoints;
                print(item2Name);

            }
            if (item.itemID == Item3ID)
            {

                print(Item3ID);
                item3Name = item.itemName;
                item3ObName = item.ObjectName;
                item3Cost = item.itemCost;
                item3Point = item.itemPoints;
                print(item3Name);

            }
            if (item.itemID == Item4ID)
            {

                print(Item4ID);
                item4Name = item.itemName;
                item4ObName = item.ObjectName;
                item4Cost = item.itemCost;
                item4Point = item.itemPoints;
                print(item4Name);

            }
            if (item.itemID == Item5ID)
            {

                print(Item5ID);
                item5Name = item.itemName;
                item5ObName = item.ObjectName;
                item5Cost = item.itemCost;
                item5Point = item.itemPoints;
                print(item5Name);


            }
            if (item.itemID == Item6ID)
            {

                print(Item6ID);
                item6Name = item.itemName;
                item6ObName = item.ObjectName;
                item6Cost = item.itemCost;
                item6Point = item.itemPoints;
                print(item6Name);


            }
            if (item.itemID == Item7ID)
            {

                print(Item7ID);
                item7Name = item.itemName;
                item7ObName = item.ObjectName;
                item7Cost = item.itemCost;
                item7Point = item.itemPoints;
                print(item7Name);


            }
            if (item.itemID == Item8ID)
            {

                print(Item8ID);
                item8Name = item.itemName;
                item8ObName = item.ObjectName;
                item8Cost = item.itemCost;
                item8Point = item.itemPoints;
                print(item8Name);


            }
            if (item.itemID == Item9ID)
            {

                print(Item9ID);
                item9Name = item.itemName;
                item9ObName = item.ObjectName;
                item9Cost = item.itemCost;
                item9Point = item.itemPoints;
                print(item9Name);


            }
            if (item.itemID == Item10ID)
            {

                print(Item10ID);
                item10Name = item.itemName;
                item10ObName = item.ObjectName;
                item10Cost = item.itemCost;
                item10Point = item.itemPoints;
                print(item10Name);


            }

        } 
        //setup items
        budget.SetupBudget(item1Cost + item2Cost + item3Cost + item4Cost + item5Cost + item6Cost + item7Cost + item8Cost + item9Cost + item10Cost + 40);

        Item1UIName.text = item1Name;
        Item2UIName.text = item2Name;
        Item3UIName.text = item3Name;
        Item4UIName.text = item4Name;
        Item5UIName.text = item5Name;
        Item6UIName.text = item6Name;
        Item7UIName.text = item7Name;
        Item8UIName.text = item8Name;
        Item9UIName.text = item9Name;
        Item10UIName.text = item10Name;


    }

    public void CheckItem(string ItemName, bool BeenScanned, bool InTrolley)
    {
        //checking item constructed
        if (ItemName == item1ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem1();

        }
        else if (ItemName == item2ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem2();

        }
        else if (ItemName == item3ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem3();

        }
        else if (ItemName == item4ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem4();

        }
        else if (ItemName == item5ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem5();

        }
        else if (ItemName == item6ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem6();

        }
        else if (ItemName == item7ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem7();

        }
        else if (ItemName == item8ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem8();

        }
        else if (ItemName == item9ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem9();

        }
        else if (ItemName == item10ObName && BeenScanned == true && InTrolley == true)
        {

            CompleteItem10();

        }
        else
        {

            print("sorry item is not in list");
            //deduct points for losing items
            

        }

    }

    
    //sets ui items to true
    void CompleteItem1()
    {
               
        //tick bool on shopping list
        other.AddPoints(item1Point);
        budget.TakeBudget(item1Cost);
        Item1Status.text = "Complete";
        print("Item 1 done");

    }
    void CompleteItem2()
    {


        //tick bool on shopping list
        other.AddPoints(item2Point);
        budget.TakeBudget(item2Cost);
        Item2Status.text = "Complete";
        print("Item 2 done");

    }
    void CompleteItem3()
    {


        //tick bool on shopping list
        other.AddPoints(item3Point);
        budget.TakeBudget(item3Cost);
        Item3Status.text = "Complete";
        print("Item 3 done");

    }
    void CompleteItem4()
    {


        //tick bool on shopping list
        other.AddPoints(item4Point);
        budget.TakeBudget(item4Cost);
        Item4Status.text = "Complete";
        print("Item 4 done");

    }
    void CompleteItem5()
    {


        //tick bool on shopping list
        other.AddPoints(item5Point);
        budget.TakeBudget(item5Cost);
        Item5Status.text = "Complete";
        print("Item 5 done");

    }
    void CompleteItem6()
    {


        //tick bool on shopping list
        other.AddPoints(item6Point);
        budget.TakeBudget(item6Cost);
        Item6Status.text = "Complete";
        print("Item 6 done");

    }
    void CompleteItem7()
    {


        //tick bool on shopping list
        other.AddPoints(item7Point);
        budget.TakeBudget(item7Cost);
        Item7Status.text = "Complete";
        print("Item 7 done");

    }
    void CompleteItem8()
    {

        //tick bool on shopping list
        other.AddPoints(item8Point);
        budget.TakeBudget(item8Cost);
        Item8Status.text = "Complete";
        print("Item 8 done");

    }
    void CompleteItem9()
    {


        //tick bool on shopping list
        other.AddPoints(item9Point);
        budget.TakeBudget(item9Cost);
        Item9Status.text = "Complete";
        print("Item 9 done");

    }
    void CompleteItem10()
    {


        //tick bool on shopping list
        other.AddPoints(item10Point);
        budget.TakeBudget(item10Cost);
        Item10Status.text = "Complete";
        print("Item 10 done");

    }
    // Update is called once per frame
    void Update()
    {



    }
    
}
