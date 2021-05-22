using UnityEngine;

//This Script is attached to the weapon on the player.
//When the Player fires the weapon/projectile it clones the item and destroys it after 8 seconds
public class weapommove : MonoBehaviour
{

        public GameObject weapon;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var clone = Instantiate(weapon, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(clone, 8.0f);
        }
    }
}
