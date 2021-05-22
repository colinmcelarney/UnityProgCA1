using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script is attached to the Enemy Soldiers.
//When the soldiers collides with the player the Apply Damage Function is called.
//This damage reduces the players health by 1 everytime a collision occurs

public class playerdamage : MonoBehaviour
{
   void OnCollisionStay(Collision other)
   {
       if (other.transform.CompareTag("Player"))

       {
           other.transform.SendMessage("ApplyDamage", 1);
       }

   }
}
