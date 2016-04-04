#pragma strict

var laserSpeed : float;
var yMax : float;

function Update () 
{
    transform.Translate(0, laserSpeed * Time.deltaTime, 0);

    if(transform.position.y > yMax)
    {
        Destroy(gameObject);
    }
}