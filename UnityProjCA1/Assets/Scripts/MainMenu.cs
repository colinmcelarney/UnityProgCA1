using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This Script loads through SceneManagement when the "Explain" Scene is called within the game
public class MainMenu : MonoBehaviour
{
    public void PlayExplain()
    {
        SceneManager.LoadScene("Explain");
    }
}
