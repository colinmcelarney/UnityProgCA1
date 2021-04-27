using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{

    
    public Text healthLabel;
    public int HealthCount = 3;
    public Text keyLabel;
    public int KeyCount = 0;

    //Public Game Objects
    public GameObject Enemy;
    public GameObject Player;
    public GameObject Well;
    public GameObject Key;

    //public GameObject Well;
    // Start is called before the first frame update
    void Start()
    {
    //scoreLabel.text = "Score : " + ScoreCount;
    healthLabel.text = "Health : " + HealthCount;
    keyLabel.text = "Key : " + KeyCount;
    //ApplyDamage(0);

        
    }

    void ApplyDamage(int damage)
    {
        if (healthLabel != null && HealthCount > 0)

        {
            healthLabel.text = "Health :" + HealthCount--;
            
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
            keyLabel.text = "Key : " + KeyCount++;
        }

    }
    
    
}
