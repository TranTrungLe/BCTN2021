using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTime : MonoBehaviour
{
    public Text textTime;
    TextTimer getT;

    // Start is called before the first frame update
    void Start()
    {
        textTime = GetComponent<Text>();
        getT = GetComponent<TextTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
