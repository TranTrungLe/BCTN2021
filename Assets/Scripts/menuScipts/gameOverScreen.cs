using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOverScreen : MonoBehaviour
{

    public Text poinText;
    public string nextLv;
   

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        poinText.text = score.ToString() + "POINTs";
    }

  
    public void restartButton()
    {
        SceneManager.LoadScene(nextLv);
        scoreTextScript.coinAmount = 0;
    }

    public void mainMenuButton()
    {
        SceneManager.LoadScene("menu");
    }
}
