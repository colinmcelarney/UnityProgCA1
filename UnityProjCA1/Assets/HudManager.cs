using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{

    //Score Labels
    //public int ScoreCount;
    public Text scoreLabel;
    public int ScoreCount = 10;

    //Public Game Objects
    public GameObject Enemy;
    //public GameObject Well;
    // Start is called before the first frame update
    void Start()
    {
    scoreLabel.text = "Score : " + ScoreCount;
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            scoreLabel.text = "Score : " + ScoreCount--;
        }
    }

    
    
}
