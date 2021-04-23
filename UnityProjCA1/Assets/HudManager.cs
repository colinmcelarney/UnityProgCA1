using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudManager : MonoBehaviour
{

    //Score Labels
    public Text scoreLabel;
    public int ScoreCount;

    //Public Game Objects
    public GameObject Enemy;
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
            scoreLabel.text = "Score : " + ScoreCount++;
        }
    }
}
