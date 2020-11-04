using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Menu : MonoBehaviour
{
    public GameObject main;

    #region Functions
    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

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
            Cursor.visible = true;
        }
        else if(main.activeSelf == false)
        {
            //If main menu not active then time is normal
            Time.timeScale = 1;
            Cursor.visible = false;
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
