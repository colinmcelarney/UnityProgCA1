using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This Script is attached to the UI Canvas Object.
//When P is pressed a Pause UI appears on the sceen giving the player the option to resume or quit.
//I watched Brackeys Youtube Video https://www.youtube.com/watch?v=JivuXdrIHK0&t=526s to get help on scripting.

public class Pause : MonoBehaviour
{

    public static bool GamePaused = false; //A bool is created to set the condition to be false at the start of the game
    public GameObject pauseMenuUI; //A Game Object UI is available in the scene.

    void Update()
    
    {
        if (Input.GetKeyDown("p")) //If button "P" is pressed during the game show the player they have two options.
    
        {
            if (GamePaused)
            {
                Resume(); //Player can choose to resume by pressing a button
            }

            else
            {
                Paused(); //If Player does not press button keep the game paused
            }
        }
    }

public void Resume ()
{
    pauseMenuUI.SetActive(false); //If Player chooses to resume make the UI turn off and continue as normal
    Time.timeScale = 1f;
    GamePaused = false;
    
}

void Paused ()
{
    pauseMenuUI.SetActive(true); //If Player pause the game show the PauseMenu UI is active. TimeScale stops. Bool is True
    Time.timeScale = 0f;
    GamePaused = true;
    
}
    
    public void Quit()
    {
        SceneManager.LoadScene("Intro"); //If Player chooses the Quit Button Load the Intro Scene
    }        
    
}
