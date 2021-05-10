using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ManagerScripts : MonoBehaviour
{
    public static float health;
    
    public static int score;
    //public playerHealth player;
    
    //public static SceneManager scene;

    public void Update()
    {
        health = playerHealth.currentHealth;
        score = scoreTextScript.coinAmount;
        
    }
}
