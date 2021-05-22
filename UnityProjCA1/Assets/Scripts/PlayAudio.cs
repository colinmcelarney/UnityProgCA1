using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Script is attached to the Plage Doctor as a explainer tool to Wolf before he enters the Village
public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public bool alreadyPlayed = false; //A bool is set to only play the audio source once only
    
    
   void OnCollisionEnter(Collision collision)
{
   if (!alreadyPlayed)
   {
       audioSource.Play();
       alreadyPlayed = true; // If Wolf collides with the Plague Doctor Play the Audio. If he collides again check to see if audio is played.
   }

   }
}