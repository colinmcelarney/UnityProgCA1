using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HudManager : MonoBehaviour
{

    
    public Text healthLabel;
    public int HealthCount = 3;

    public static bool GamePaused = false;
    //public Text keyLabel;
    //public int KeyCount = 0;

    //Public Game Objects
    public GameObject Enemy;
    public GameObject Player;
    public GameObject Well;
    //public GameObject Key;
    public GameObject door;
    public GameObject pauseMenuUI;

    //public GameObject Well;
    // Start is called before the first frame update
    void Start()
    {
    //scoreLabel.text = "Score : " + ScoreCount;
    healthLabel.text = "Health : " + HealthCount;
    //keyLabel.text = "Key : " + KeyCount;
    //ApplyDamage(0);

        
    }

    void ApplyDamage(int damage)
    {
        if (healthLabel != null && HealthCount > 0)

        {
            healthLabel.text = "Health :" + HealthCount--;
            
        }

        if (HealthCount <= 0)
        {
            SceneManager.LoadScene ("Explain");
        }
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.tag == "Player")
        //{
        //    scoreLabel.text = "Score : " + ScoreCount--;
        //}
    

       // if (other.gameObject.tag == "Enemy")
        //{
         //   healthLabel.text = "Health : " + HealthCount--;
        //}

        if (other.gameObject.tag == "Well")
        {
            healthLabel.text = "Health : " + HealthCount++;
        }

        else if (other.gameObject.tag == "Key")
        {
           // keyLabel.text = "Key : " + KeyCount++;
            //gameObject.SetActive(false);
            door.transform.position += new Vector3(0, 0, 100);
        
        }

        
    }

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
        SceneManager.LoadScene("Explain");
    }

    public void Quit()
    {
        SceneManager.LoadScene("Intro");
    }    
}
