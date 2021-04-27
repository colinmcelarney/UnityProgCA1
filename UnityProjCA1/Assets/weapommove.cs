using UnityEngine;

public class weapommove : MonoBehaviour
{

        public GameObject weapon;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var clone = Instantiate(weapon, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(clone, 30.0f);
        }
    }
}
