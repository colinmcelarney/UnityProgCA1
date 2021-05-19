using UnityEngine;

//This script turns the object arrow dissapear from the game after a collision with an object.
//This script is attached the projectile object under the sword weapon
public class arrowhit : MonoBehaviour
{
   void OnCollisionEnter()

       {
        gameObject.SetActive(false); //on collision the arrow weapon is not active anymore.
    }
}
