using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour
{
    public static int knightsKilled = 0; //int for how many knights have been killed
    private int requiredKnights = 10;
    public Text killCount; //text for how many knights have been killed

    public GameObject winScreen, gameOver;
    private Dragon dStats;
    public float currentHealth;
    public float maxHealth;
    public Slider healthBar;

    void TakeDamage(float damage)
    {
        currentHealth = currentHealth - damage;
        healthBar.value = currentHealth;
    }

    public void Win()
    {
        if (knightsKilled >= requiredKnights) //if how many knights have been killed is greater than how many need to be killed
        {
            //stop time and win screen
            Time.timeScale = 0;
            winScreen.SetActive(true);   
        }
        else if (currentHealth <= 0)
        {
            gameOver.SetActive(true);
            winScreen.SetActive(false);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Precursor to if soldiers come into a range of dragon then take damage
        {
            TakeDamage(10f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        killCount.text = "Kill Count: " + knightsKilled;
        Win();
    }
}


    
