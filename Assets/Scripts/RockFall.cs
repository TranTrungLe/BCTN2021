using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFall : MonoBehaviour
{
    public float aliveTime;
    //public GameObject player;
    public GameObject rockFall;
    public bool playerInRange;
    public GameObject warning;

    // Start is called before the first frame update
    void Start()
    {   
        rockFall.SetActive(false);
        warning.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            rockFall.SetActive(true);
            warning.SetActive(true);
            //Debug.Log("tadaa");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //playerInRange = true;
            //rockFall.SetActive(true);
            warning.SetActive(false);
            //Debug.Log("tadaa");
        }
    }
}
