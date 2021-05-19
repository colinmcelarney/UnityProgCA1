using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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