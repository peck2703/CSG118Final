using UnityEngine;
using System.Collections;

public class FireScript : MonoBehaviour
{
    public GameObject laser;                        //Stores the game object of laser to instantiate
    public float fireFrequency;                     //How often you can fire
    float lastShot;                                 //Time since last firing of laser
    float laserTimer;                               //How long the power up lasts
    int laserType;                                 //Powerup determines what laser type shows up
    AudioSource audioFile;                          //Controls the audio clip or picks various ones

	void Start ()                                   // Use this for initialization
    {
        audioFile = GetComponent<AudioSource>();    //Grab the components in Start() always
        laserType = 0;
	}
	
	void Update ()                                  // Update is called once per frame
    {
        if (Input.GetMouseButton(0) && (Time.time > lastShot + fireFrequency))          //Can fire again
        {
            print("Key Pressed");
            Fire();                                                                     //Calls fire Method
            laserTimer -= Time.time;                                               //Countdown for powerup use. 10 is a multiplier just because
            if (laserTimer < 0)                                                         //Timer is over
            {
                laserType = 0;                                                          //LaserType 0 is standard
            }
        }
    }
    void Fire()
    {
        print("In Fire");
        lastShot = Time.time;                                                                       //Sets the next lastShot so we can fire after the fireFrequency time is up
        
        if (laserType == 0)                                                                         //Standard Laser
        {
            Instantiate(laser, transform.position, Quaternion.Euler(0,0,90));                             //Instantiate the standard laser
        }
        else if (laserType == 1)                                                                    //Powered up laser
        {
            Instantiate(laser, transform.position, Quaternion.Euler(new Vector3(0, 0, -40)));       //Creates 5 separate lasers in 5 directions 
            Instantiate(laser, transform.position, Quaternion.Euler(new Vector3(0, 0, -20)));
            Instantiate(laser, transform.position, transform.rotation);
            Instantiate(laser, transform.position, Quaternion.Euler(new Vector3(0, 0, 20)));
            Instantiate(laser, transform.position, Quaternion.Euler(new Vector3(0, 0, 40)));
        }
    }
    public void PowerUpLaser()
    {
        laserType++;                                                                    //Increments the laser type to fire powered up laser
        audioFile.Play();                                                               //Play the audio file
        laserTimer = 5;                                                                 //Set the laser time to 5
        laserType = Mathf.Clamp(laserType, 0, 1);                                       //Clamps the laserType so it doesn't go above the maximum
    }
    public void RebelPowerUpPower()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for(int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i].gameObject);
        }
    }
    public void EmpirePowerUpPower()
    {
        laserType++;                                                                    //Increments the laser type to fire powered up laser
        audioFile.Play();                                                               //Play the audio file
        laserTimer = 5;                                                                 //Set the laser time to 5
        laserType = Mathf.Clamp(laserType, 0, 1);                                       //Clamps the laserType so it doesn't go above the maximum
    }
}
