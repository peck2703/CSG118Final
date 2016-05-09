using UnityEngine;
using System.Collections;

public class Enemy1Movement : MonoBehaviour
{
    public float xMult;                     //Multiplier for faster movement
    public int points;
    public Vector2 playerPos;
    public bool isHorizontal = true;
    public float xMin, xMax, yMin, yMax;

	void Start ()                           // Use this for initialization
    {
        if (points < 100)
        {
            points = 100;                   //minimum of 100 points
        }
    }
	
	void Update ()                          // Update is called once per frame
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        if (isHorizontal)
        {
            while (transform.position.y != playerPos.y)
            {
                transform.position = new Vector3(Mathf.Clamp(Time.deltaTime, xMin, xMax) * Time.deltaTime, Mathf.Clamp(playerPos.y, yMin, yMax) * Time.deltaTime, 0);
            }
                //transform.position = new Vector3(Mathf.PingPong(Time.time * xMult, enemyWiggle.x), (initPos.y + Mathf.PingPong(Time.time, enemyWiggle.y)), 0);              //Ping-Pong the enemy against the xMin and xMax
        }
    }
}
