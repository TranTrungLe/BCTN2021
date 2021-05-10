using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int collectedKeys, victoryCondition = 2;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            DestroyImmediate(this);
        }
    }

    private static GameManager instance;

    public static GameManager MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }

            return instance;
        }
    }

    private void Start()
    {
        UIManager.MyInstance.UpdateKeyUI(collectedKeys, victoryCondition);
    }

    public void AddKeys(int keys)
    {
        collectedKeys += keys;
        UIManager.MyInstance.UpdateKeyUI(collectedKeys, victoryCondition);
    }
}
