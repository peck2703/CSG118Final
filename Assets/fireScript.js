#pragma strict

var laser : GameObject;
var fireFrequency : float;
private var lastShot : float;


function Update () 
{
    if(Input.GetMouseButton(0) && (Time.time > lastShot + fireFrequency))
    {
        Fire();
    }
}
function Fire()
{
    lastShot = Time.time;
    
    Instantiate(laser, transform.position, transform.rotation);

}