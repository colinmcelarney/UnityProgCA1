using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

