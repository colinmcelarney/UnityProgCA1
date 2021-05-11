using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
    
    {
        if (Input.GetKeyDown("p"))
        {
            if (GamePaused)
            {
                Resume();
            }

            else
            
            {
                Paused();
            }
        }
    }

public void Resume ()
{
    pauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    GamePaused = false;
    //GetComponent<AudioSource>().Play();
}

void Paused ()
{
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GamePaused = true;
    //GetComponent<AudioSource>().Pause();
}
    public void MainMenu()
    {
    if (Input.GetKeyDown("m"))
    {
        SceneManager.LoadScene("Explain");
    }
    }
    public void Quit()
    {
        SceneManager.LoadScene("Intro");
    }        
    
}
