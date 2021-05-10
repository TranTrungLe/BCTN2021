using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class simpleLoad : MonoBehaviour
{
    //public GameObject managerScript;
    public string levelToLoad;
    public GameObject player;
    
    public void Load()
    {

        if (ES3.KeyExists("playerPosition"))
        {
            player.transform.position = ES3.Load<Vector3>("playerPosition");
        }

        if (ES3.KeyExists("saveScene"))
        {
            levelToLoad = ES3.Load<string>("saveScene");
            SceneManager.LoadScene(levelToLoad);
        }
        
        //Debug.Log("load!!!");

        if (ES3.KeyExists("health"))
        {
            ManagerScripts.health = ES3.Load<float>("health");
        }
        if (ES3.KeyExists("score"))
        {
            ManagerScripts.health = ES3.Load<int>("score");
        }


       
        //ManagerScripts.health = ES3.Load("health", ManagerScripts.health);
        //ManagerScripts.score = ES3.Load("score", ManagerScripts.score);
        //player.transform.position = ES3.Load("playerPosition", player.transform.position);
        

    }
}
