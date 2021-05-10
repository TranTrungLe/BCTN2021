using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text txtKey, txtVictoryCondition;
    public GameObject victoryCondition;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    private static UIManager instance;

    public static UIManager MyInstance
    {
        get
        {
            if (instance == null) 
            {
                instance = new UIManager();
            }

            return instance;
        }
    }

    public void UpdateKeyUI(int key, int victoryCondition)
    {
        txtKey.text = "Keys: " + key + "/" + victoryCondition;
    }
}
