using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//This Script shows UI information within the Game including Health of the Player and If the Player has the Key
//This Script is attached to the Player in the Game
public class HudManager : MonoBehaviour
{

    public Text healthLabel; //Text UI Interface to display Players Health.
    public int HealthCount = 100; //Text UI to display Players HealthCount which is set to 100 at the start of the game.

    public Text keyLabel; //Text UI Interface to display if the Player has a Key to open the Tressure Box.
    public int KeyCount = 0; //Text UI to display KeyCount which is set to 0 at the start of the game.

    //Public Game Objects
    public GameObject Enemy; //Enemy Object in Game 
    public GameObject Player; //Player Object in Game
    public GameObject Well; //Well Object 
    public GameObject Key; //Key Object
    public GameObject door; //Door Object
    

    // Start is called before the first frame update
    void Start()
    {
    healthLabel.text = "Health : " + HealthCount; //UI Shows the Value of Health in HealthLabel at start of Game
    keyLabel.text = "Key : " + KeyCount; //UI Shows value of Key in KeyLabel at start of Game    
    }

    //The Code below applys damage to the player and shows the damage applied to the player by decrementing the value when the apply damage funtion is called.
    //If the HealthCount reaches less than 0 use the SceneManager to Load the "Eplain" scene
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

    //The Code below applys health to the player and shows the health value increment when the apply health function is called.

    void ApplyHealth(int health)
    {
        healthLabel.text = "Health :" + HealthCount++;
    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Well")
        {
            healthLabel.text = "Health : " + HealthCount++; //If the Player collides with the Well Item increment your health value.
            
        }

        else if (other.gameObject.tag == "Key")
        {
            keyLabel.text = "Key : " + KeyCount+1;
            door.transform.position += new Vector3(0, 0, 100); //If the Player collides with the Key Item increment the Key Count by 1 and move the Door Object so that door opens
        
        }

        
    }

       
}
