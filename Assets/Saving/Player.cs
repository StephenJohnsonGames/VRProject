using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //does mean that a file has to be encryted and created everytime its saved but should work fine for this project
    public int currentchapter = 5;
    public void SavePlayer ()
    {

        SaveSystem.SavePlayer(this);

    }
    public void LoadPlayer ()
    {

        PlayerSaveData data = SaveSystem.LoadPlayer();

        currentchapter = data.chapter;

    }

}
