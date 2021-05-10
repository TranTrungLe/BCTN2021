using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestOpen : MonoBehaviour
{
    public GameObject chestCLose;

    public GameObject chest;

    public GameObject theDrop;
    //public bool drops;


    // Start is called before the first frame update
    void Start()
    {
        chestCLose.SetActive(true);
        chest.SetActive(false);
        theDrop.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            chestCLose.SetActive(false);
            chest.SetActive(true);
            theDrop.SetActive(true);
        }
        //if (drops)
        //{
        //    Instantiate(theDrop);
        //}

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag =="Player")
        {
            chestCLose.SetActive(true);
            chest.SetActive(false);
        }
        
    }
}
