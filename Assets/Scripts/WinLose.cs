using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour
{
    public static int knightsKilled = 0; //int for how many knights have been killed
    private int requiredKnights = 10;
    public Text killCount; //text for how many knights have been killed

    public GameObject winScreen, gameOver;
    public Dragon player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        killCount.text = "Kill Count: " + knightsKilled;
        Win();
    }


    public void Win()
    {
        if (knightsKilled >= requiredKnights) //if how many knights have been killed is greater than how many need to be killed
        {
            //stop time and win screen
            Time.timeScale = 0;
            winScreen.SetActive(true);   
        }
        else if (player.currentHealth <= 0) //else if dragon health is 0 then game over
        {
            gameOver.SetActive(true);
            winScreen.SetActive(false);
        }

    }

}


    
