using UnityEngine;
using System.Collections;

public class Enemy1Collision : MonoBehaviour
{
    public GameObject explosion;                                                        //Create an intance of the explosion by storing it in a variable

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Laser")                                            //Get the tag off the object on Trigger
        {
            if(explosion)                                                               //Check if explosion exists so we don't instantiate nothing
            {
                Instantiate(explosion, transform.position, transform.rotation);

                Destroy(other.gameObject);                                              //Destroy the laser first then the enemy
                Destroy(gameObject);
            }
        }
    }
}
