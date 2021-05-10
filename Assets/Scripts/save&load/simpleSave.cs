using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class simpleSave : MonoBehaviour
{
    public GameObject managerScript;
    public GameObject player;

    public void Save()
    {
        //ManagerScripts script = managerScript.GetComponent<ManagerScripts>();
        //float health = script.health;
        
        ES3.Save("saveScene", SceneManager.GetActiveScene().name);
        ES3.Save("score", ManagerScripts.score);
        ES3.Save("health", ManagerScripts.health);

        ES3.Save("playerPosition", player.transform.position);

    }
}
