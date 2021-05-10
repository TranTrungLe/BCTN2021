using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditionToMove : MonoBehaviour
{
    public GameObject condition;
    public bool playerInRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && playerInRange)
        {
            if (condition.activeInHierarchy)
            {
                condition.SetActive(false);
            }
            else
            {
                condition.SetActive(true);
                //condition.text = dialog;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            //condition.SetActive(true);
            //warning.SetActive(true);
            //Debug.Log("tadaa");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            //hint.SetActive(false);
        }
    }
}
