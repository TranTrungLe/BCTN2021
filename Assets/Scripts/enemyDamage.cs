using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{

    public float damage;
    public float damegeRate;
    public float pushBackForce;

    float nextDamage;

    // Start is called before the first frame update
    void Start()
    {
        nextDamage = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D orther)
    {
        if(orther.tag == "Player" && nextDamage<Time.time)
        {
            playerHealth thePlayerHealth = orther.gameObject.GetComponent<playerHealth>();
            thePlayerHealth.addDamage(damage);
            nextDamage = Time.time + damegeRate;

            pushBack(orther.transform);
        }
    }

    void pushBack(Transform pushedOject)
    {
        Vector2 pushDirection = new Vector2(0, (pushedOject.position.y - transform.position.y)).normalized;
        pushDirection *= pushBackForce;
        Rigidbody2D pushRB = pushedOject.gameObject.GetComponent<Rigidbody2D>();
        pushRB.velocity = Vector2.zero;
        pushRB.AddForce(pushDirection, ForceMode2D.Impulse);
    }

}
