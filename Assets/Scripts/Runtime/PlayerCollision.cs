using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public GameObject explosion;                                                        //Stores the game object of laser to instantiate
    public GameObject sceneManagerGO;

    void Start()
    {
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyLaser")                                       //Get the tag off the object on Trigger
        {
            sceneManagerGO.GetComponent<sceneManager>().SubtractLife();
            if (explosion)                                                              //Check if explosion exists so we don't instantiate nothing
            {
                Instantiate(explosion, transform.position, transform.rotation);
            }
            Destroy(other.gameObject);                                                  //Destroy the laser first then the enemy
            Destroy(gameObject);
        }
    }
}
