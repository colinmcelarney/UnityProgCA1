using UnityEngine;

//This script sets the speed of the projectile after being fired. 
//The script is attached to the projectile object. The projectile is tagged as the arrow.
public class arrowmove : MonoBehaviour
{
   public float speed = 15f;  //speed of the projectile when fired.

   void Update()
   {
       transform.Translate(Vector3.forward * speed * Time.deltaTime); // Moves the projectile forward multiplied by the speed of the object.
   }
}
