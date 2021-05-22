using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script is attached to the Tressure chest 
//When the Player collides with the chest the You Win Scene Loads.

public class YouWin : MonoBehaviour
{
   void OnCollisionStay(Collision other)
   {
       if (other.transform.CompareTag("Player"))

       {
           SceneManager.LoadScene("YouWin");
       }

   }
}