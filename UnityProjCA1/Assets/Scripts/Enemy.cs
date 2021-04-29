using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{


public GameObject Key;

    
       void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
        }

       
    }
    
}