using UnityEngine;

//This script is attached to the Enemy Soldiers, their health value changes when they are hit with the Arrow

public class EnemyDamage : MonoBehaviour
{
    private int hitNumber; //int called hitNumber

    void OnCollisionEnter(Collision other)

    {
        if (other.transform.CompareTag("Arrow")) 

        {
            hitNumber++; //if the projectile collides make the int increment 
        }
        if (hitNumber == 3)

        {
            Destroy(gameObject); //if hitNumber equals to 3 destroy the Enemy 
        }

    }
}
