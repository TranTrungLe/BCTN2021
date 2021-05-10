using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    //public GameObject bulletParent;

    [SerializeField]
    private Transform shootForm;

    private Transform target;

    [SerializeField]
    private float atkCooldown;
    public float timer;
    private bool cooling;
    private float intTimer;

    //private bool canAttack = true;

    //public float timeSinceAttack;


    void Awake()
    {
        intTimer = timer; //Store the inital value of timer
    }

    // Update is called once per frame
    private void Update()
    {
        Shoot();
    }


    public void Shoot()
    {
        GameObject go = Instantiate(bullet, shootForm.position, Quaternion.identity);

        Vector3 direction = new Vector3(transform.localScale.x, 0);

        go.GetComponent<Projectile>().Setup(direction);

        timer = intTimer;

        Cooldown();
    }

    /*public void OnCollisionEnter2D(GameObject other)
    {
        if(other.tag=="Player")
        {
            this.target = other.transform;
        }
    }*/

    void Cooldown()
    {
        timer -= Time.deltaTime;

        if (timer <= 0 && cooling)
        {
            cooling = false;
            timer = intTimer;
        }
    }


}
