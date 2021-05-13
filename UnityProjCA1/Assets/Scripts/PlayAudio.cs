using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource playAudio;

   void OnTriggerEnter(Collider other)
   {
       playAudio.Play();
   }
}
