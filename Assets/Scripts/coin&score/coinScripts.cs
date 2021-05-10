using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScripts : MonoBehaviour
{
    public int scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        scoreTextScript.coinAmount += scoreValue;
        Destroy(gameObject);

        if (scoreTextScript.coinAmount > HighScore.highscore)
        {
            HighScore.highscore = scoreTextScript.coinAmount;
        }
    }  

}
