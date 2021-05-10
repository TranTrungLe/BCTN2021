using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class saveSystem 
{
    
    public static void savePlayer(playerHealth player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = "E:\\unity\\The Adventure\\Save";
        FileStream stream = new FileStream(path, FileMode.Create);

        playerData data = new playerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static playerData LoadPlayer ()
    {
        string path = "E:\\unity\\The Adventure\\Save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            playerData data = formatter.Deserialize(stream) as playerData;
            stream.Close();

            return data;
        }else
        {
            Debug.LogError("Save file is not found in " + path);
            return null;
        }
    }

}
