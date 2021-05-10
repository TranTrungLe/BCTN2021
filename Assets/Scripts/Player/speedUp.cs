using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUp : MonoBehaviour
{
    private playerController thePlayer;
    public float duration;
    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<playerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine("SpeedUp");
        }
    }

    IEnumerator SpeedUp()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        thePlayer.maxSpeed += 3;
        yield return new WaitForSeconds(duration);
        thePlayer.maxSpeed = thePlayer.dfltSpeed;
        Destroy(gameObject);
    }
}
