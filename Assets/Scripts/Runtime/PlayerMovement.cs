using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;                                   //Multiplier for faster movement
    public float xMin;                                          //Creating a clamp on the x-axis for the player
    public float xMax;      
    public float yMin;                                          //Creating a clamp on the y-axis for the player
    public float yMax;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed, Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed, 0);               //Each tick, move the object by a vector

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0);                          //Moves the player based on the clamp on both the x- and y-axis
    }
}
