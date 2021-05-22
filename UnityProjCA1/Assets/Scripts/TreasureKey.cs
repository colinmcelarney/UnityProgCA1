using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This Script is attached to the Key object in the Village.

public class TreasureKey : MonoBehaviour
{

public GameObject Key;

       void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            
            Destroy(gameObject); //If the Player collides with the Key Object, the key is detroyed.
        }

       
    }
    
}