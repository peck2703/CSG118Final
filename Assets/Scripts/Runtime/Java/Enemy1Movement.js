#pragma strict

var initPos : Vector3;
//var xMax : float;
//var yMin : float;
var xMult : float;
var enemyWiggle : Vector2;

function Start () 
{
    initPos = transform.position;
}

function Update () 
{
    transform.position.x = Mathf.PingPong(Time.time * xMult, enemyWiggle.x);
    transform.position.y = initPos.y + Mathf.PingPong(Time.time, enemyWiggle.y);
}