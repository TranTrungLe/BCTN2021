using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{

    public float fullHealth;
    public GameObject deathFX;
    public AudioClip playerHurt;

    [SerializeField]
    private Text healthValue;

    //Timer
    //public TextTimer playerTime;

    // Game OverScreen
    public gameOverScreen gameOverScreen;
    int maxPlatform = 0;

    public static float currentHealth;

    playerController controlMovement;

    public AudioClip playerDeathSound;
    AudioSource playerAS;

    //HUD Variable
    public Slider healthSlider;
    public Image damageScreen;

    //public Text gameOverScreen;
    public Text winGameScreen;
    public GameObject winP;
    

    bool damaged = false;
    Color damageColour = new Color(0f, 0f, 0f, 0.5f);
    float smoothColour = 5f;

    /*public void gameOver()
    {
        gameOverScreen.Setup(maxPlatform);
    }*/

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = fullHealth;

        controlMovement = GetComponent<playerController>();

        //HUD Initilization
        healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;

        string[] tmp = healthValue.text.Split(':');
        healthValue.text = tmp[0] + ":" + currentHealth;

        damaged = false;

        playerAS = GetComponent<AudioSource>();

        winP.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(damaged)
        {
            damageScreen.color = damageColour;
        }else
        {
            damageScreen.color = Color.Lerp(damageScreen.color, Color.clear, smoothColour*Time.deltaTime);
        }
        damaged = false;
    }

    public void addDamage(float damage)
    {
        if(damage<=0)
        {
            return;
        }
        currentHealth -= damage;

        //playerAS.clip = playerHurt;
        //playerAS.Play();

        playerAS.PlayOneShot(playerHurt);

        healthSlider.value = currentHealth;
        damaged = true;

        string[] tmp = healthValue.text.Split(':');
        healthValue.text = tmp[0] + ":" + currentHealth;

        if (currentHealth<=0)
        {
            makeDead();
        }
    }

    public void addHealth(float healthAmount)
    {
        currentHealth += healthAmount;
        if(currentHealth>fullHealth)
        {
            currentHealth = fullHealth;
        }
        healthSlider.value = currentHealth;

        string[] tmp = healthValue.text.Split(':');
        healthValue.text = tmp[0] + ":" + currentHealth;
    }

    public void makeDead()
    {
        Instantiate(deathFX, transform.position, transform.rotation);
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(playerDeathSound, transform.position);
        damageScreen.color = damageColour;

        //Animator gameOverAnimator = gameOverScreen.GetComponent<Animator>();
        //gameOverAnimator.SetTrigger("gameOver");
        
        gameOverScreen.Setup(maxPlatform);

        TextTimer.x = false;
        

        /*playerTime = GetComponent<TextTimer>();
        playerTime.isTimer = false;*/



    }

    public void winGame()
    {
        Destroy(gameObject);
        Animator winGameAnimator = winGameScreen.GetComponent<Animator>();
        winP.SetActive(true);
        winGameAnimator.SetTrigger("gameOver");
    }

    //Save

    /*public void savePlayer()
    {
        Debug.Log("save succsecc");
        saveSystem.savePlayer(this);
    }

    public void loadPlayer()
    {
        Debug.Log("load succsecc");
        playerData data = saveSystem.LoadPlayer();

        healthSlider.value = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }*/

}
