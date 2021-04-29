using UnityEngine;

public class arrowmove : MonoBehaviour
{
   public float speed = 10f;

   void Update()
   {
       transform.Translate(Vector3.forward * speed * Time.deltaTime);
   }
}
