using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    Text hightext;

    public static int highscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        hightext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hightext.text = highscore.ToString();
    }
}
