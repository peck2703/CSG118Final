using UnityEngine;
using System.Collections;

public class LaserMovement : MonoBehaviour
{
    public bool horizontal = false;
    public float laserSpeed;
    public float max;                                                              //Creating a clamp on the y-axis to destroy the laser
    public float min;                                                              //if it goes beyond either float value

	void Update ()                                                                  // Update is called once per frame
    {
        if (!horizontal)
        {
            transform.Translate(0, laserSpeed * Time.deltaTime, 0);                     //Each tick, move the object by a vector

            if (transform.position.y > max || (transform.position.y < min))           //Object moves beyond the clamp
            {
                Destroy(gameObject);                                                    //Destroy Game Object
            }
        }
        else if(horizontal)
        {
            transform.Translate(laserSpeed * Time.deltaTime,0 , 0);                     //Each tick, move the object by a vector

            if (transform.position.x > max || (transform.position.x < min))           //Object moves beyond the clamp
            {
                Destroy(gameObject);                                                    //Destroy Game Object
            }
        }
    }
}
