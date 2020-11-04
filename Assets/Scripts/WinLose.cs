using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour
{
    public int knightsKilled = 0; //int for how many knights have been killed
    public Text killCount; //text for how many knights have been killed
    public GameObject winScreen, gameOver;

    public void Win()
    {
        if (knightsKilled >= 10)
        {
            Time.timeScale = 0;
            winScreen.SetActive(true);
        }
        else
        {
            gameOver.SetActive(true);
            winScreen.SetActive(false);
        }
    }

    public void ScoreHolder() 
    {
        knightsKilled++;
        killCount.text = "Knights Killed:  " + killCount;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreHolder();
        Win();
    }
}
