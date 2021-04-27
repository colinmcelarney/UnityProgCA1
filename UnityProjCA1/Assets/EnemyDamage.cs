using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private int hitNumber;

    void OnCollisionEnter(Collision other)

    {
        if (other.transform.CompareTag("Arrow"))

        {
            hitNumber++;
        }
        if (hitNumber == 3)

        {
            Destroy(gameObject);
        }

    }
}
