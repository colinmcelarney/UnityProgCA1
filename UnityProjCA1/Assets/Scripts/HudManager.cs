using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HudManager : MonoBehaviour
{

    
    public Text healthLabel;
    public int HealthCount = 100;

    public Text keyLabel;
    public int KeyCount = 0;

    //Public Game Objects
    public GameObject Enemy;
    public GameObject Player;
    public GameObject Well;
    public GameObject Key;
    public GameObject door;
    

    // Start is called before the first frame update
    void Start()
    {
    healthLabel.text = "Health : " + HealthCount;
    keyLabel.text = "Key : " + KeyCount;

        
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

    void ApplyHealth(int health)
    {
        healthLabel.text = "Health :" + HealthCount++;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Well")
        {
            healthLabel.text = "Health : " + HealthCount++;
            
        }

        else if (other.gameObject.tag == "Key")
        {
            keyLabel.text = "Key : " + KeyCount+1;
            door.transform.position += new Vector3(0, 0, 100);
        
        }

        
    }

    void Update()
    {
        
    }
       
}
