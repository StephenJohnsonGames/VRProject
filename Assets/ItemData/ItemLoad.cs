using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public const string path = "items";

    void Start()
    {

        ItemContainer ic = ItemContainer.Load(path);

        foreach (Item item in ic.items)
        {

            print(item.itemName);

        }

    }
}
