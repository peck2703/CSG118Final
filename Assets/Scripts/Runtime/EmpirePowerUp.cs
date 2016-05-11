using UnityEngine;
using System.Collections;

public class EmpirePowerUp : MonoBehaviour
{
    GameObject player;                                                      //Stores the game object of player to power up the laser

    void Start()                                                            //Use this for initialization
    {
        player = GameObject.FindGameObjectWithTag("Player");                //Find the player using the tag "Player"
    }
    void OnTriggerEnter2D(Collider2D other)                                 //Trigger events
    {
        if (other.gameObject.tag == "Player")                               //Player triggers the event
        {
            player.GetComponent<FireScript>().EmpirePowerUpPower();               //Calls the power up laser from the player character

            Destroy(gameObject);                                            //Destroy object
        }
    }
}
