using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class Menu : MonoBehaviour
{
    public GameObject main;

    #region Functions

    private void Update()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        //ESC key pressed, stops time for main menu to appear
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //stop time and make main menu appear
            Time.timeScale = 0;
            main.SetActive(true);
        }
        else if(main.activeSelf == false)
        {
            //If main menu not active then time is normal
            Time.timeScale = 1;
        }
        
    }
    

    public void QuitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #endif
        Application.Quit();
    }
    #endregion
}
