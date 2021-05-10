using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winGame : MonoBehaviour
{
    //public static bool GameIsPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerHealth playerWins = other.gameObject.GetComponent<playerHealth>();
            playerWins.winGame();
            //GameIsPaused = false;
            //Time.timeScale = 0f;
        }
        
    }

}
