using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script is attached to the Well Object in the Village
//If the Player collides with the Well the Apply Health Function is applied and increments by 1
public class playerHealth : MonoBehaviour
{
   void OnCollisionStay(Collision other)
   {
       if (other.transform.CompareTag("Player"))

       {
           other.transform.SendMessage("ApplyHealth", 1);
       }

   }
}

