using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public bool alreadyPlayed = false;
    
    //public bool played = false;

//void Start()
//{

    //audio = GetComponent<AudioSource>();
//}
   void OnCollisionEnter(Collision collision)
{
   if (!alreadyPlayed)
   {
       audioSource.Play();
       alreadyPlayed = true;
   }
}
}