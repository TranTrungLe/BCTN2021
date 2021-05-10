using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveTrigger : MonoBehaviour
{
    public GameObject managerScript;
    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            ES3.Save("saveScene", SceneManager.GetActiveScene().name);
            ES3.Save("score", ManagerScripts.score);
            ES3.Save("health", ManagerScripts.health);

            ES3.Save("playerPosition", player.transform.position);

            //this.gameObject.SetActive(false);

            Debug.Log("nice");
        }
    }

}
