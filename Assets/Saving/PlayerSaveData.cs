using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//able to save it in a file
[System.Serializable]
public class PlayerSaveData
{

    //vairables we need
    public int chapter;

        //player or whatever script we gather player data from
    public PlayerSaveData (Player player)
    {

        //connect the above to the ones within player
        //e.g

        chapter = player.currentchapter;
        
    }


}
