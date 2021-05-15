using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public bool alreadyPlayed = false;
    
    
   void OnCollisionEnter(Collision collision)
{
   if (!alreadyPlayed)
   {
       audioSource.Play();
       alreadyPlayed = true;
   }

   }
}