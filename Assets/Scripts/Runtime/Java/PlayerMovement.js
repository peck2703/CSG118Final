#pragma strict

var playerSpeed :   float;
var xMin        :   float;
var xMax        :   float;
var yMin        :   float;
var yMax        :   float;

function Update () 
{
    transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed, Input.GetAxis("Vertical")* Time.deltaTime* playerSpeed, 0);

    transform.position.x = Mathf.Clamp(transform.position.x, xMin, xMax);
    transform.position.y = Mathf.Clamp(transform.position.y, yMin, yMax);
}