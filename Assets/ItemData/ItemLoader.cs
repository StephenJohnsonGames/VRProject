using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoader : MonoBehaviour
{

    public const string path = "items";

    void Start()
    {

        ItemContainer ic = ItemContainer.Load(path);

        foreach (Item item in ic.items)
        {
            if (item.itemID == 29)
            {

                print(item.itemName);
                print(item.itemCost);
                print(item.itemPoints);

            }

        }

    }

}
