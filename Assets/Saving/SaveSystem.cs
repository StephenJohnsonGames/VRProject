
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem { 


    public static void SavePlayer (Player player)
    {

        BinaryFormatter formatter = new BinaryFormatter();
        //path can have a random name and .path
        string path = Application.persistentDataPath + "/player.data";

        FileStream fileStream = new FileStream(path, FileMode.Create);

        PlayerSaveData Pdata = new PlayerSaveData(player);
        //creating the path and creating the file
        formatter.Serialize(fileStream, Pdata);
        fileStream.Close();

    }

    public static PlayerSaveData LoadPlayer()
    {
        //checking if path exists or not
        string path = Application.persistentDataPath + "/player.data";
        if (File.Exists(path))
        {

            BinaryFormatter formatter = new BinaryFormatter();
            FileStream openStream = new FileStream(path, FileMode.Open);

            PlayerSaveData savedData = formatter.Deserialize(openStream) as PlayerSaveData;
            openStream.Close();
            return savedData;
            //returns saved data

        }
        else
        {
            //if it doesnt print error
            Debug.LogError("No save file " + path);
            return null;

        }

    }


}
