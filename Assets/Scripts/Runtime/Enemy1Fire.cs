using UnityEngine;
using System.Collections;

public class Enemy1Fire : MonoBehaviour
{
    public float fireFrequency;
    public GameObject enemyLaser;
    float lastShot;

	void Update ()                                                                  // Update is called once per frame
    {
        if (Time.time > lastShot + fireFrequency)                                   //Check for valid time to shoot, after fireFrequency is over
        {
            Fire();
        }
    }
    void Fire()
    {
        if (enemyLaser)                                                             //Check if enemy laser GO exists before we instantiate the object
        {
            lastShot = Time.time;                                                   //Set the next lastshot
            Instantiate(enemyLaser, transform.position, transform.rotation);
        } 
    }
}
