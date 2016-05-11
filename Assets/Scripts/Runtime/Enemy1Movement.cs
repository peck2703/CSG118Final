using UnityEngine;
using System.Collections;

public class Enemy1Movement : MonoBehaviour
{
    public int points;
    public float playerPos;
    public bool isHorizontal = true;
    public float xMin, xMax, yMin, yMax;
    public float movementSpeed = 5.0f;
    public float range;

	void Start ()                           // Use this for initialization
    {
        if (points < 100)
        {
            points = 100;                   //minimum of 100 points
        }
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position.y;
    }
	
	void Update ()                          // Update is called once per frame
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position.y;
        if (isHorizontal)
        {
            if (transform.position.y != (playerPos - range) )
            {                                
                transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, playerPos -Random.Range(-range, range), 0), Time.deltaTime);
            }
            if(transform.position.x != xMin)
            {
                Vector3.Lerp(new Vector3(transform.position.x, playerPos, 0), transform.position, Time.deltaTime * movementSpeed);
            }
        }
    }
}
