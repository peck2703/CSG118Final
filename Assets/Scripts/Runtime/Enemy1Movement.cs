using UnityEngine;
using System.Collections;

public class Enemy1Movement : MonoBehaviour
{
    public Vector3 initPos;
    public float xMult;                     //Multiplier for faster movement
    public Vector2 enemyWiggle;             //Makes the player move up and down partially
    public int points;

	void Start ()                           // Use this for initialization
    {
        initPos = transform.position;       //Grab the initial position from the transform on Awake
        if (points < 100)
        {
            points = 100;                   //minimum of 100 points
        }
    }
	
	void Update ()                          // Update is called once per frame
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * xMult, enemyWiggle.x), (initPos.y + Mathf.PingPong(Time.time, enemyWiggle.y)), 0);              //Ping-Pong the enemy against the xMin and xMax
    }
}
