#pragma strict

var fireFrequency : float;
var enemyLaser : GameObject;
private var lastShot : float;

function Update () 
{
    if (Time.time > lastShot + fireFrequency)
    {
        Fire();
    }
}
function Fire()
{
    lastShot = Time.time;
    Instantiate(enemyLaser, transform.position, transform.rotation);
}