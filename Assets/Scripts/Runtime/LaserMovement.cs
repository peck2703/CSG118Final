using UnityEngine;
using System.Collections;

public class LaserMovement : MonoBehaviour
{
    public float laserSpeed;
    public float yMax;                                                              //Creating a clamp on the y-axis to destroy the laser
    public float yMin;                                                              //if it goes beyond either float value

	void Update ()                                                                  // Update is called once per frame
    {
        transform.Translate(0, laserSpeed * Time.deltaTime, 0);                     //Each tick, move the object by a vector

        if (transform.position.y > yMax || (transform.position.y < yMin))           //Object moves beyond the clamp
        {
            Destroy(gameObject);                                                    //Destroy Game Object
        }
    }
}
