using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class keyCondition : MonoBehaviour
{
    private int collectedKeys, victoryCondition = 2;

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
