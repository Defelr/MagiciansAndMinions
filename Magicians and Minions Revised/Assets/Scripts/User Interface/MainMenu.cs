/* 
This script holds functions for the main menu including:
   - Loading Scenes
   - Displaying Panels
   - Exiting the game
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


    /* Variables */

    //UI Panels
    public GameObject titlePanel;
    public GameObject mainMenuPanel;
    public GameObject helpPanel;
    public GameObject creditsPanel;
    

    /* Fuctions */
    
    public void HelpPanel() //shows or hides the help panel
    {
        bool active = helpPanel.activeInHierarchy;
        if(active == false)
        {
            titlePanel.SetActive(false);
            mainMenuPanel.SetActive(false);
            helpPanel.SetActive(true);
        }
        else
        {
            helpPanel.SetActive(false);
            titlePanel.SetActive(true);
            mainMenuPanel.SetActive(true);
        }
    }

    public void CreditsPanel() //shows or hides the credits panel
    {
        bool active = creditsPanel.activeInHierarchy;
        if(active == false)
        {
            titlePanel.SetActive(false);
            mainMenuPanel.SetActive(false);
            creditsPanel.SetActive(true);
        }
        else
        {
            creditsPanel.SetActive(false);
            titlePanel.SetActive(true);
            mainMenuPanel.SetActive(true);
        }
    }
    
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
